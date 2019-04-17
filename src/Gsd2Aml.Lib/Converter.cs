using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Gsd2Aml.Lib.Models;
using System.Xml.Serialization;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Lib
{
    public class Converter
    {
        private static ISO15745Profile GsdObject { get; set; }
        private static CAEXFile AmlObject { get; } = new CAEXFile();
        private static List<XmlNode> GsdTranslationElements { get; } = new List<XmlNode>();

        private const string CTranslationTableFileName = "gsd2aml.xml";

        /// <summary>
        /// Deserializes the translation table and the GSD-file and then starts the conversion process.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="stringOutput">A boolean whether a file output or a string output is needed.</param>
        public static void Convert(string inputFile, string outputFile, bool stringOutput)
        {
            var serializer = new XmlSerializer(typeof(ISO15745Profile));
            var translationTable = new XmlDocument();

            // Deserialize GSD-file
            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                try
                {
                    GsdObject = (ISO15745Profile)serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    Util.Logger.Log(LogLevel.Error, e.Message);
                    Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                    throw new Exception("Invalid GSD-file. Failed to serialize the GSD-File.");
                }
            }

            // Load translation table
            translationTable.Load(CTranslationTableFileName);

            if (translationTable.DocumentElement == null)
            {
                Util.Logger.Log(LogLevel.Error, "Could not load the translation table.");
                throw new Exception("Could not load the translation table. Please contact the developers.");
            }

            // Add all conversion rules to a list
            foreach (XmlNode node in translationTable.DocumentElement.ChildNodes)
            {
                GsdTranslationElements.Add(node);
            }

            // Set FileName property of global CAEX-element 
            AmlObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("FileName"))?.SetValue(AmlObject, new FileInfo(outputFile).Name);

            Handle(AmlObject, GsdObject);
        }

        private static void Handle<TA, TG>(TA amlParent, TG gsdParent)
        {
            if (gsdParent == null)
            {
                return;
            }

            foreach (var propertyInfo in gsdParent.GetType().GetProperties())
            {
                if (propertyInfo.GetValue(gsdParent) == null)
                {
                    continue;
                }
                
                if (GsdTranslationElements.FirstOrDefault(node => node.Name.Equals(propertyInfo.Name)) is var translationRule && translationRule != null)
                {
                    var gsdInstance = propertyInfo.GetValue(gsdParent);
                    Translate(gsdInstance, translationRule);
                }

                // call handle function
            }
        }

        private static void Translate<TG>(TG gsdObject, XmlNode translationRule)
        {

        }

        /// <summary>
        /// Searches recursivley an object down to find a property by a string.
        /// </summary>
        /// <param name="currentHeadObject">The reference to an object which is the current head object.</param>
        /// <param name="propertyName">The name of the property which will be searched.</param>
        /// <param name="currentPropertyInfo">Optional parameter which exits for array handling in this recursive function.</param>
        /// <returns>The property info object of the found property or null if it does not exist.</returns>
        private static PropertyInfo GetPropertyFromString(object currentHeadObject, string propertyName, PropertyInfo currentPropertyInfo = null)
        {
            if (currentHeadObject == null)
            {
                return null;
            }

            if (currentHeadObject.GetType().IsArray && currentPropertyInfo != null)
            {
                return currentPropertyInfo;
            }

            foreach (var propertyInfo in currentHeadObject.GetType().GetProperties())
            {
                if (propertyInfo.Name.Equals(propertyName))
                {
                    return propertyInfo;
                }

                if (propertyInfo.GetValue(currentHeadObject) == null || IsSimpleType(propertyInfo.GetValue(currentHeadObject).GetType())) continue;

                var prop = GetPropertyFromString(propertyInfo.GetValue(currentHeadObject), propertyName, propertyInfo);

                if (prop != null)
                {
                    return prop;
                }
            }
            return null;
        }

        /// <summary>
        /// Checks if a given Type is a simple/primitive type.
        /// </summary>
        /// <param name="type">The type which should be checked.</param>
        /// <returns>A boolean which indicated if the given type is a simple type.</returns>
        private static bool IsSimpleType(Type type)
        {
            return type.IsPrimitive ||
                   new[] { typeof(Enum), typeof(string), typeof(decimal), typeof(DateTime), typeof(DateTimeOffset), typeof(TimeSpan), typeof(Guid) }.Contains(type.GetTypeInfo()) ||
                   System.Convert.GetTypeCode(type) != TypeCode.Object ||
                   (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0]));
        }
    }
}
