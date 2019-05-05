using Gsd2Aml.Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace Gsd2Aml.Lib
{
    public class Util
    {
        public static Logging.ILoggingService Logger { get; set; }

        /// <summary>
        /// Gets the property information (PropertyInfo, Type, bool isArray) of a string.
        /// The string indicates a way through the properties. The different "stations" are separated by dots.
        /// </summary>
        /// <param name="searchedProperty">The by dots separated string.</param>
        /// <param name="propertyInfo">The searched property which will be set.</param>
        /// <param name="propertyType">The searched type which will be set.</param>
        /// <param name="isPropertyArray">The boolean which indicates if the property is an array.</param>
        internal static void GetProperty(string searchedProperty, out PropertyInfo propertyInfo, out Type propertyType, out bool isPropertyArray)
        {
            // Set default values for the out parameters.
            propertyInfo = null;
            isPropertyArray = false;
            propertyType = null;

            // Split strings by the letter dot.
            var splittedStrings = searchedProperty.Split('.').ToList();

            // Iterate over the splittedStrings array and find step by step the searched property.
            foreach (var splittedString in splittedStrings)
            {
                var currentType = propertyInfo == null ? typeof(Wrapper) : propertyInfo.PropertyType;
                propertyInfo = SearchPropertyByString(currentType, splittedString);

                if (propertyInfo == null) return;
            }

            if (propertyInfo == null) return;

            // Set the other out parameters.
            isPropertyArray = propertyInfo.PropertyType.IsArray;
            propertyType = isPropertyArray
                            ? propertyInfo.PropertyType.GetElementType()
                            : propertyInfo.PropertyType;
        }

        /// <summary>
        /// Searches recursiveley a class down to find a property by string.
        /// </summary>
        /// <param name="type">The type object, which represents the currently iterated class.</param>
        /// <param name="propertyName">The name of the property being searched for.</param>
        /// <returns>The PropertyInfo object if the property was found or null if it does not exist.</returns>
        private static PropertyInfo SearchPropertyByString(Type type, string propertyName)
        {
            // Check if the current type is the searched type.
            var prop = type.GetProperty(propertyName);

            if (prop != null)
            {
                return prop;
            }

            // Iterate over all local declared public properties of the current type.
            return (from property in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
                // Get the type object of the property for comparison reasons.
                select property.PropertyType.IsArray ? property.PropertyType.GetElementType() : property.PropertyType into propertyType
                // Check that the type is not a simple type and that the property is not the same as the currently iterated property due to possible stackoverflow exception.
                where !IsSimpleType(propertyType) && type != propertyType
                // Recursive call of the current iterated property. If it is not null, it is the searched property.
                select SearchPropertyByString(propertyType, propertyName)).FirstOrDefault(x => x != null);
        }

        /// <summary>
        /// Checks if a given type is a simple/primitive type.
        /// </summary>
        /// <param name="type">The type which should be checked.</param>
        /// <returns>A boolean which indicates if the given type is a simple type.</returns>
        private static bool IsSimpleType(Type type)
        {
            return type.IsPrimitive ||
                   new[] { typeof(Enum), typeof(string), typeof(decimal), typeof(DateTime), typeof(DateTimeOffset), typeof(TimeSpan), typeof(Guid) }.Contains(type.GetTypeInfo()) ||
                   Convert.GetTypeCode(type) != TypeCode.Object ||
                   (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0]));
        }

        /// <summary>
        /// This function gets the relevant information (replacement, references) from a translation rule.
        /// </summary>
        /// <param name="translationRule">The translation rule that is parsed.</param>
        /// <param name="replacement">The actual replacement.</param>
        /// <param name="references">A list which will save all replacements.</param>
        internal static void GetInformationFromRule(ref XmlNode translationRule, out XmlNode replacement, out ICollection<XmlNode> references)
        {
            // Initialize all out parameters with default values.
            references = new List<XmlNode>();
            replacement = null;

            var alreadyReadReplacement = false;

            // Iterate over the child nodes of the replacement.
            foreach (XmlNode xmlNode in translationRule.ChildNodes)
            {
                switch (xmlNode.Name)
                {
                    case "Reference":
                        references.Add(xmlNode);
                        break;
                    case "Replacement":
                        if (alreadyReadReplacement)
                        {
                            throw new InvalidDataException("Translation table has mutliple replacements for a rule.");
                        }
                        replacement = xmlNode.FirstChild;
                        alreadyReadReplacement = true;
                        break;
                    default:
                        throw new InvalidDataException("Translation table has unknown element.");
                }
            }

            // Check if replacement is null.
            if (replacement != null) return;
            throw new InvalidDataException("Translation table has no replacement for a rule.");
        }
    }
}
