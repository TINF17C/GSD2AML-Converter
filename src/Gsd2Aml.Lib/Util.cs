using Gsd2Aml.Lib.Logging;
using Gsd2Aml.Lib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Gsd2Aml.Lib
{
    internal static class Util
    {
        private const string CTranslationTableFileName = "gsd2aml.xml";

        /// <summary>
        /// Gets the property information (PropertyInfo, Type, bool isArray) of a string.
        /// The string indicates a way through the properties. The different "stations" are separated by dots.
        /// </summary>
        /// <param name="searchedProperty">The by dots separated string.</param>
        /// <returns>The property info, the type of the found property and if the type is an array.</returns>
        internal static (PropertyInfo, Type, bool) GetProperty(string searchedProperty)
        {
            Converter.Logger?.Log(LogLevel.Info, $"Search following property {searchedProperty}");

            PropertyInfo propertyInfo = null;

            // Split strings by the letter dot.
            var splitStrings = searchedProperty.Split('.').ToList();

            // Iterate over the splitStrings array and find step by step the searched property.
            foreach (var splitString in splitStrings)
            {
                var currentType = propertyInfo == null ? typeof(Wrapper) : propertyInfo.PropertyType;
                propertyInfo = SearchPropertyByString(currentType, splitString);

                Converter.Logger?.Log(LogLevel.Info, $"Found the property {propertyInfo?.Name} with this declaring type {propertyInfo?.DeclaringType}.");

                if (propertyInfo == null) break;
            }

            if (propertyInfo == null)
            {
                Converter.Logger?.Log(LogLevel.Info, $"Property was not found {searchedProperty}");
                throw new NullReferenceException("A property was not found.");
            }

            // Set the other out parameters.
            var isPropertyArray = propertyInfo.PropertyType.IsArray;
            var propertyType = isPropertyArray
                                ? propertyInfo.PropertyType.GetElementType()
                                : propertyInfo.PropertyType;

            Converter.Logger?.Log(LogLevel.Info, $"Found valid property for {searchedProperty}. " +
                                       $"Property: {propertyInfo} " +
                                       $"Type: {propertyType} " +
                                       $"Declaring Type: {propertyInfo.DeclaringType} " +
                                       $"Is array: {isPropertyArray}");

            return (propertyInfo, propertyType, isPropertyArray);
        }

        /// <summary>
        /// Searches recursively a class down to find a property by string.
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
        /// <returns>The replacement node and a list which contains all references.</returns>
        internal static (XmlNode, ICollection<XmlNode>) GetInformationFromRule(XmlNode translationRule)
        {
            Converter.Logger?.Log(LogLevel.Info, $"Parsing the rule for {translationRule.Name}.");

            // Initialize all out parameters with default values.
            var references = new List<XmlNode>();
            XmlNode replacement = null;

            // Iterate over the child nodes of the replacement and save these correctly.
            var alreadyReadReplacement = false;
            foreach (XmlNode xmlNode in translationRule.ChildNodes)
            {
                Converter.Logger?.Log(LogLevel.Info, $"Reading following XmlNode: {xmlNode.Name}");
                switch (xmlNode.Name)
                {
                    case "Reference":
                        references.Add(xmlNode);
                        break;
                    case "Replacement":
                        if (alreadyReadReplacement)
                        {
                            Converter.Logger?.Log(LogLevel.Error, "Translation table has mutliple replacements for a rule." +
                                                      $"First replacement: {replacement.FirstChild.Name}" +
                                                      $"Second replacement: {xmlNode.FirstChild.Name}");
                            throw new XmlException("Translation table has mutliple replacements for a rule.");
                        }
                        replacement = xmlNode.FirstChild;
                        alreadyReadReplacement = true;
                        break;
                    default:
                        Converter.Logger?.Log(LogLevel.Error, $"Translation table has an unknown element. The name of the node: {xmlNode.Name}");
                        throw new XmlException("Translation table has an unknown element.");
                }
            }

            Converter.Logger?.Log(LogLevel.Info, "Successfully got the information out of the translation rule.");

            // Check if replacement is null.
            if (replacement != null) return (replacement, references);

            Converter.Logger?.Log(LogLevel.Error, $"Rule {translationRule.Name} does not have any replacement for a rule.");
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
                    Converter.Logger?.Log(LogLevel.Error, $"Failed to deserialize the GSD-File correctly. Path to the GSD file: {inputFile}");
                    throw new XmlException($"Invalid GSD-file. Failed to deserialize the GSD-File correctly. Path to the GSD file: {inputFile}", e);
                }
            }
            Converter.Logger?.Log(LogLevel.Info, $"GSD file was deserialized correctly. Path to the GSD file: {inputFile}");
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
                Converter.Logger?.Log(LogLevel.Error, $"XmlDocument could not be load. Input file path: {filePath}");
                throw new XmlException("Could not load a XML file.");
            }
            Converter.Logger?.Log(LogLevel.Info, $"XmlDocument was loaded. Input file path: {filePath}");
            return xmlDocument;
        }

        /// <summary>
        /// This method loads the translation table. There are two different cases for loading the table.
        /// The translation table is in the installation folder located and named like 'gsd2aml.xml'.
        /// If the translation table is not in the installation folder, it will be loaded from resources.
        /// </summary>
        /// <returns>Returns the translation table XmlDocument object.</returns>
        internal static XmlDocument LoadTranslationsTable()
        {
            var translationTable = new XmlDocument();

            var assembly = Assembly.GetExecutingAssembly();

            var assemblyFolder = Path.GetDirectoryName(assembly.Location);

            if (null != assemblyFolder)
            {
                var translationTableLocation = Path.Combine(assemblyFolder, CTranslationTableFileName);
                if (File.Exists(translationTableLocation))
                {
                    return LoadXmlDocument(translationTableLocation);
                }
            }

            var translationTableResource = assembly.GetManifestResourceNames().First(x => x.EndsWith(CTranslationTableFileName));

            var translationTableResourceStream = assembly.GetManifestResourceStream(translationTableResource);

            if (translationTableResourceStream == null)
            {
                Converter.Logger?.Log(LogLevel.Error, "The translation table resource stream is null.");
                throw new NullReferenceException("The translation table resource stream is null.");
            }

            using (var reader = new StreamReader(translationTableResourceStream))
            {
                translationTable.LoadXml(reader.ReadToEnd());
            }

            return translationTable;
        }

        /// <summary>
        /// This function generates the correct output file name for the string conversion method.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <returns>The correctly generated output file name.</returns>
        internal static string GetOutputFileName(string inputFile)
        {
            if (string.IsNullOrEmpty(inputFile))
            {
                Converter.Logger?.Log(LogLevel.Error, "Input file is invalid.");
                throw new ArgumentException("Input file ");
            }

            var fileName = Path.GetFileNameWithoutExtension(inputFile);

            fileName = fileName.StartsWith("GSDML-", StringComparison.InvariantCultureIgnoreCase)
                        ? fileName.Remove(0, "GSDML-".Length)
                        : fileName;
            fileName += ".aml";

            var directoryName = Path.GetDirectoryName(inputFile);

            if (!string.IsNullOrEmpty(directoryName)) return Path.Combine(directoryName, fileName);

            Converter.Logger?.Log(LogLevel.Error, $"Input file describes no valid directory {inputFile}");
            throw new NullReferenceException("Directory name of the input file is invalid.");
        }

        /// <summary>
        /// This function creates the an instance out of a type and a flag whether an array needs to be created.
        /// </summary>
        /// <param name="propertyType">The type object which describes the type of the instance.</param>
        /// <param name="isPropertyArray">Flag which indicates whether an array is needed.</param>
        /// <returns>An instance of the type which the propertyType parameter describes. If an array is needed, it creates a list.</returns>
        internal static dynamic CreateInstance(Type propertyType, bool isPropertyArray)
        {
            // If the translation Property is a string, it has to be handled manually because it does not have a constructor with no parameters.
            if (propertyType == typeof(string))
            {
                return string.Empty;
            }
            return isPropertyArray
                    ? Activator.CreateInstance(typeof(List<>).MakeGenericType(propertyType))
                    : Activator.CreateInstance(propertyType);
        }
    }
}
