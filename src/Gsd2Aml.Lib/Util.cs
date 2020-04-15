/*
 *  Copyright (C) 2019 GSD2AML Team (Nico Dietz, Steffen Gerdes, Constantin Ruhdorfer,
 *  Jonas Komarek, Phuc Quang Vu, Michael Weidmann)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published by
 *  the Free Software Foundation version 3 of the License.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Gsd2Aml.Lib.Logging;
using Gsd2Aml.Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace Gsd2Aml.Lib
{
    /// <summary>
    /// Contains utility functions which provide helping functionalities for the conversion process.
    /// </summary>
    public static class Util
    {
        private const string CTranslationTableFileName = "gsd2aml.xml";

        private const string CTextPath = "ProfileBody.ApplicationProcess.ExternalTextList.PrimaryLanguage";
        private const string CRealTextName = "Text";
        private const string CRealTextId = "TextId";
        private const string CReferenceTextId = "TextId";
        private const string CRealValueTextName = "Value";

        internal const string CGraphicPath = "ProfileBody.ApplicationProcess.GraphicsList";
        internal const string CRealGraphicName = "GraphicItem";
        private const string CRealGraphicId = "ID";
        private const string CReferenceGraphicId = "GraphicItemTarget";
        internal const string CRealValueGraphicName = "GraphicFile";

        internal static string RelativeGsdFilePath { get; set; }

        /// <summary>
        /// Gets the property information (PropertyInfo, Type, bool isArray) of a string.
        /// The string indicates a way through the properties. The different "stations" are separated by dots.
        /// </summary>
        /// <param name="searchedProperty">The by dots separated string.</param>
        /// <returns>The property info, the type of the found property and if the type is an array.</returns>
        internal static (PropertyInfo, Type, bool) GetProperty(string searchedProperty)
        {
            Converter.Logger?.Log(LogLevel.Debug, $"Search following property {searchedProperty}");

            PropertyInfo propertyInfo = null;

            // Split strings by the letter dot.
            var splitStrings = searchedProperty.Split('.').ToList();

            // Iterate over the splitStrings array and find step by step the searched property.
            foreach (var splitString in splitStrings)
            {
                var currentType = propertyInfo == null ? typeof(Wrapper) : propertyInfo.PropertyType;
                propertyInfo = SearchPropertyByString(currentType, splitString);

                Converter.Logger?.Log(LogLevel.Debug, $"Found the property {propertyInfo?.Name} with this declaring type {propertyInfo?.DeclaringType}.");

                if (propertyInfo == null) break;
            }

            if (propertyInfo == null)
            {
                Converter.Logger?.Log(LogLevel.Error, $"Property was not found {searchedProperty}");
                throw new NullReferenceException("A property was not found.");
            }

            var isPropertyArray = propertyInfo.PropertyType.IsArray;
            var propertyType = isPropertyArray
                                ? propertyInfo.PropertyType.GetElementType()
                                : propertyInfo.PropertyType;

            Converter.Logger?.Log(LogLevel.Debug, $"Found valid property for {searchedProperty}. " +
                                                    $"Property: {propertyInfo} " +
                                                    $"Type: {propertyType} " +
                                                    $"Declaring Type: {propertyInfo.DeclaringType} " +
                                                    $"Is array: {isPropertyArray}");

            return (propertyInfo, propertyType, isPropertyArray);
        }

        /// <summary>
        /// Recursively searches a class to find a property by string.
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
        internal static (XmlNode, Dictionary<string, string>, List<XmlNode>) GetInformationFromRule(XmlNode translationRule)
        {
            Converter.Logger?.Log(LogLevel.Debug, $"Parsing the rule for {translationRule.Name}.");

            // Initialize all out parameters with default values.
            var xmlNodeReferences = new List<XmlNode>();
            XmlNode replacement = null;

            // Iterate over the child nodes of the replacement and save these correctly.
            var alreadyReadReplacement = false;
            foreach (XmlNode xmlNode in translationRule.ChildNodes)
            {
                Converter.Logger?.Log(LogLevel.Debug, $"Reading following XmlNode: {xmlNode.Name}");
                switch (xmlNode.Name)
                {
                    case "Reference":
                        xmlNodeReferences.Add(xmlNode);
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
                    case "#comment":
                        break;
                    default:
                        Converter.Logger?.Log(LogLevel.Error, $"Translation table has an unknown element. The name of the node: {xmlNode.Name}");
                        throw new XmlException("Translation table has an unknown element.");
                }
            }
            Converter.Logger?.Log(LogLevel.Debug, "Successfully got the information out of the translation rule.");

            // Check if replacement is null.
            if (replacement != null) return (replacement, ParseReferences(xmlNodeReferences), xmlNodeReferences);

            Converter.Logger?.Log(LogLevel.Error, $"Rule {translationRule.Name} does not have any replacement for a rule.");
            throw new XmlException("Translation table has no replacement for a rule.");
        }

        /// <summary>
        /// Parses the references given in the translation table and saves them to a dictionary.
        /// </summary>
        /// <param name="ruleReferences">The references in a list of XmlNodes.</param>
        /// <param name="xmlNode">Optional parameter which is a GSD tag and will be used instead of the iterated one.</param>
        /// <returns>A dictionary which contains for each reference identifier the correct value.</returns>
        internal static Dictionary<string, string> ParseReferences(IEnumerable<XmlNode> ruleReferences, XmlNode xmlNode = null)
        {
            var references = new Dictionary<string, string>();

            foreach (var reference in ruleReferences)
            {
                var referenceAttributes = reference.Attributes;
                if (referenceAttributes == null)
                {
                    Converter.Logger?.Log(LogLevel.Error, "Reference of a rule has no attributes.");
                    throw new InvalidDataException("Reference of a rule has no attributes.");
                }

                var referenceId = referenceAttributes["Ref"]?.Value;

                if (referenceId == null)
                {
                    Converter.Logger?.Log(LogLevel.Error, "Reference of a rule has no key.");
                    throw new InvalidDataException("Reference of a rule has no key.");
                }

                var referenceType = referenceAttributes["Type"]?.Value;

                switch (referenceType)
                {
                    case "TextRef":
                        var referenceTextValue = ParseRealReference(CTextPath, reference, CReferenceTextId, CRealTextId, CRealTextName, CRealValueTextName, xmlNode);
                        references.Add(referenceId, referenceTextValue);
                        break;
                    case "GraphicRef":
                        var referenceGraphicValue = ParseRealReference(CGraphicPath, reference, CReferenceGraphicId, CRealGraphicId, CRealGraphicName, CRealValueGraphicName, xmlNode);
                        references.Add(referenceId, referenceGraphicValue);
                        break;
                    case "RelGsdFilePath":
                        references.Add(referenceId, RelativeGsdFilePath);
                        break;
                    case null:
                        var referenceChild = reference.FirstChild;
                        var referenceChildAttributes = referenceChild.Attributes;

                        if (referenceChildAttributes == null)
                        {
                            continue;
                        }

                        var referenceChildAttributeName = referenceChildAttributes[0].Name;

                        var gsd = xmlNode ?? IterateThroughGsdDocument(referenceChild.Name);

                        var gsdAttributes = gsd?.Attributes;

                        if (gsdAttributes?[referenceChildAttributeName] == null)
                        {
                            continue;
                        }

                        if (gsd.Attributes != null)
                            references.Add(referenceId, gsd.Attributes[referenceChildAttributeName].Value);
                        break;
                    default:
                        Converter.Logger?.Log(LogLevel.Error, "Reference does not have a valid/supported type.");
                        throw new InvalidDataException("Reference does not have a valid/supported type.");
                }
            }
            return references;
        }

        /// <summary>
        /// Parse real references (TextRef, GraphicRef) and find the correct value.
        /// </summary>
        /// <param name="path">Path to the real GSD element.</param>
        /// <param name="reference">The reference contains the reference.</param>
        /// <param name="referenceIdName">The referenceIdName contains the name of the reference id.</param>
        /// <param name="realIdName">The realIdName contains the name of the real id.</param>
        /// <param name="realElementName">The realElementname contains the name of the real element tag.</param>
        /// <param name="realValueName">The realValueName contains the name of the real value attribute.</param>
        /// <param name="xmlNode">Optional parameter which is a GSD tag and will be used instead of the iterated one.</param>
        /// <returns>The value of the real reference.</returns>
        private static string ParseRealReference(string path, XmlNode reference, string referenceIdName, string realIdName, string realElementName, string realValueName, XmlNode xmlNode)
        {
            var refNode = xmlNode ?? IterateThroughGsdDocument(reference.FirstChild.Name);

            if (!refNode.Name.EndsWith(reference.FirstChild.Name.Split('.').Last()))
            {
                refNode = IterateThroughGsdDocument(reference.FirstChild.Name, (XmlElement)xmlNode);
            }

            if (refNode.Attributes == null) return null;
            var refId = refNode.Attributes[referenceIdName]?.Value;

            if (refId == null)
            {
                Converter.Logger?.Log(LogLevel.Warning, $"GSD reference element does not have a valid reference id.");
                throw new InvalidDataException($"GSD reference element does not have a valid id.");
            }

            var realNode = IterateThroughGsdDocument(path);
            var realNodeItemList = realNode.GetElementsByTagName(realElementName);

            foreach (XmlNode realItem in realNodeItemList)
            {
                var realItemAttributes = realItem.Attributes;

                if (realItemAttributes == null)
                {
                    Converter.Logger?.Log(LogLevel.Warning, $"GSD real element does not have any attributes.");
                    throw new InvalidDataException($"GSD real element does not have any attributes.");
                }

                if (realItemAttributes[realIdName].Value.Equals(refId))
                {
                    return realItemAttributes[realValueName].Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Iterates through the GSD document with the given path.
        /// </summary>
        /// <param name="path">The by dots seperated path through the GSD docment.</param>
        /// <param name="alternativeIterator">Optional parameter. If it is set the iteration starts from there.</param>
        /// <returns>The last XmlNode of the path.</returns>
        internal static XmlElement IterateThroughGsdDocument(string path, XmlElement alternativeIterator = null)
        {
            var splitStrings = path.Split('.');
            var iteratorNode = alternativeIterator ?? Converter.GsdDocument.DocumentElement;

            if (iteratorNode == null)
            {
                Converter.Logger?.Log(LogLevel.Debug, $"Could not find the right GSD node for this rule: {path}");
                return null;
            }

            foreach (var splitString in splitStrings)
            {
                iteratorNode = iteratorNode[splitString];

                if (iteratorNode != null) continue;

                Converter.Logger?.Log(LogLevel.Debug, $"Could not find the right GSD node for this rule: {path}");
                return null;
            }
            return iteratorNode;
        }

        /// <summary>
        /// This method checks the GSD file against the the xsd-files and validates it.
        /// </summary>
        /// <param name="inputFile">The path to the GSD file.</param>
        internal static void CheckGsdFileForCorrectness(string inputFile)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(inputFile);

            var assembly = Assembly.GetExecutingAssembly();
            var xsdResources = assembly.GetManifestResourceNames().Where(x => x.EndsWith(".xsd"));

            var settings = new XmlReaderSettings {DtdProcessing = DtdProcessing.Ignore, ValidationType = ValidationType.Schema};
            
            foreach (var xsdFile in xsdResources)
            {
                var xsdResourceStream = assembly.GetManifestResourceStream(xsdFile);
                if (xsdResourceStream == null)
                {
                    Converter.Logger?.Log(LogLevel.Error, "The xsd file resource stream is null.");
                    throw new NullReferenceException("The xsd file resource stream is null.");
                }

                var xmlReader = XmlReader.Create(xsdResourceStream, settings);
                xmlDocument.Schemas.Add(null, xmlReader);
            }

            try
            {
                xmlDocument.Validate(null);
            }
            catch (Exception e)
            {
                Converter.Logger?.Log(LogLevel.Error, $"Failed to deserialize the GSD-File correctly. {e.Message} Path to the GSD file: {inputFile}");
                throw new XmlException($"Invalid GSD-file. Failed to deserialize the GSD-File correctly. {e.Message} Path to the GSD file: {inputFile}", e);
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
        internal static XmlDocument LoadTranslationTable()
        {
            var translationTable = new XmlDocument();
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyFolder = Path.GetDirectoryName(assembly.Location);

            if (assemblyFolder != null)
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
        public static string GetOutputFileName(string inputFile)
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
        /// This function creates the an instance out of a type and a flag whether an array needs to be created or not.
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
