using Gsd2Aml.Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Lib
{
    public static class Util
    {
        public static ILoggingService Logger { get; set; }

        private const string CTranslationTableFileName = "gsd2aml.xml";

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
            Logger.Log(LogLevel.Info, $"Search following property {searchedProperty}");

            // Set default values for the out parameters.
            propertyInfo = null;

            // Split strings by the letter dot.
            var splittedStrings = searchedProperty.Split('.').ToList();

            // Iterate over the splittedStrings array and find step by step the searched property.
            foreach (var splittedString in splittedStrings)
            {
                var currentType = propertyInfo == null ? typeof(Wrapper) : propertyInfo.PropertyType;
                propertyInfo = SearchPropertyByString(currentType, splittedString);

                Logger.Log(LogLevel.Info, $"Found the property {propertyInfo?.Name} with this declaring type {propertyInfo?.DeclaringType}.");

                if (propertyInfo == null) break;
            }

            if (propertyInfo == null)
            {
                Logger.Log(LogLevel.Info, $"Property was not found {searchedProperty}");
                throw new NullReferenceException("A property was not found.");
            }

            Logger.Log(LogLevel.Info, $"The property {propertyInfo.Name} with this declaring type {propertyInfo.DeclaringType} was found.");

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
                    // Check that the type is not a simple type and that the property is not the same as the currently iterated property due to possible StackOverflow exception.
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
            Logger.Log(LogLevel.Info, $"Parsing the rule for {translationRule.Name}.");

            // Initialize all out parameters with default values.
            references = new List<XmlNode>();
            replacement = null;

            // Iterate over the child nodes of the replacement and save these correctly.
            var alreadyReadReplacement = false;
            foreach (XmlNode xmlNode in translationRule.ChildNodes)
            {
                Logger.Log(LogLevel.Info, $"Reading following XmlNode: {xmlNode.Name}");
                switch (xmlNode.Name)
                {
                    case "Reference":
                        references.Add(xmlNode);
                        break;
                    case "Replacement":
                        if (alreadyReadReplacement)
                        {
                            Logger.Log(LogLevel.Error, "Translation table has mutliple replacements for a rule." +
                                                      $"First replacement: {replacement.FirstChild.Name}" +
                                                      $"Second replacement: {xmlNode.FirstChild.Name}");
                            throw new XmlException("Translation table has mutliple replacements for a rule.");
                        }
                        replacement = xmlNode.FirstChild;
                        alreadyReadReplacement = true;
                        break;
                    default:
                        Logger.Log(LogLevel.Error, $"Translation table has an unknown element. The name of the node: {xmlNode.Name}");
                        throw new XmlException("Translation table has an unknown element.");
                }
            }

            // Check if replacement is null.
            if (replacement != null) return;
            
            Logger.Log(LogLevel.Error, $"Rule {translationRule.Name} does not have any replacement for a rule.");
            throw new XmlException("Translation table has no replacement for a rule.");
        }

        /// <summary>
        /// This method deserializes the GSD file to check if it is syntactically correct.
        /// </summary>
        /// <param name="inputFile">The path to the GSD file.</param>
        internal static void CheckGsdFileForCorrectness(string inputFile)
        {
            var serializer = new XmlSerializer(typeof(ISO15745Profile));
            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                try
                {
                    _ = serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    Logger.Log(LogLevel.Error, $"Failed to deserialize the GSD-File correctly. Path to the GSD file: {inputFile}");
                    throw new XmlException($"Invalid GSD-file. Failed to deserialize the GSD-File correctly. Path to the GSD file: {inputFile}", e);
                }
            }
            Logger.Log(LogLevel.Info, $"GSD file was deserialized correctly. Path to the GSD file: {inputFile}");
        }

        /// <summary>
        /// This method loads an XML file to an XmlDocument and returns it.
        /// </summary>
        /// <param name="filePath">The file path as a string.</param>
        /// <returns>The XmlDocument object which contains the deserialized form of the XML file.</returns>
        internal static XmlDocument LoadXmlDocument(string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            if (xmlDocument.DocumentElement == null)
            {
                Logger.Log(LogLevel.Error, $"XmlDocument could not be load. Input file path: {filePath}");
                throw new XmlException("Could not load a XML file.");
            }
            Logger.Log(LogLevel.Info, $"XmlDocument was loaded. Input file path: {filePath}");
            return xmlDocument;
        }

        /// <summary>
        /// This method loads the translation table. There are two different cases for loading the table.
        /// The translation table is in the installtion folder loacated and named like 'gsd2aml.xml'.
        /// If the translation table is not in the installtion folder, it will be loaded from resources.
        /// </summary>
        /// <returns>Returns the translation table XmlDocument object.</returns>
        internal static XmlDocument LoadTranslationsTable()
        {
            var translationTable = new XmlDocument();

            if (File.Exists(CTranslationTableFileName))
            {
                return LoadXmlDocument(CTranslationTableFileName);
            }

            var assembly = Assembly.GetExecutingAssembly();
            var translationTableResource = assembly.GetManifestResourceNames().First(x => x.EndsWith(CTranslationTableFileName));

            var translationTableResourceStream = assembly.GetManifestResourceStream(translationTableResource);

            if (translationTableResourceStream == null)
            {
                Logger.Log(LogLevel.Error, "The translation table resource stream is null.");
                throw new NullReferenceException("The translation table resource stream is null.");
            }

            using (var reader = new StreamReader(translationTableResourceStream))
            {
                translationTable.LoadXml(reader.ReadToEnd());
            }

            return translationTable;
        }
    }
}
