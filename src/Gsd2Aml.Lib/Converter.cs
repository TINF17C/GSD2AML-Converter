using Gsd2Aml.Lib.Logging;
using Gsd2Aml.Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Gsd2Aml.Lib
{
    // TODO: When migrating to .NET Core or .NET 7 use multiple return values instead of the out parameter.
    public static class Converter
    {
        private static CAEXFile AmlObject { get; } = new CAEXFile();

        private static List<XmlNode> TranslationRules { get; } = new List<XmlNode>();

        /// <summary>
        /// The convert function which returns the AML file as string.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <returns>The AML object serailzed to a XML string.</returns>
        public static string Convert(string inputFile)
        {
            Util.Logger.Log(LogLevel.Info, "Conversion to string started.");
            StartConversion(inputFile, Util.GetOutputFileName(inputFile));

            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(AmlObject.GetType());
                serializer.Serialize(stringwriter, AmlObject);
                return stringwriter.ToString();
            }
        }

        // TODO: get ressources
        /// <summary>
        /// The convert function which will create a .amlx file.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        public static void Convert(string inputFile, string outputFile, bool overwriteFile)
        {
            Util.Logger.Log(LogLevel.Info, "Conversion to file started.");
            StartConversion(inputFile, outputFile);

            var serializer = new XmlSerializer(AmlObject.GetType());
            var temporaryPath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(outputFile) + ".aml");
            using (var textWriter = new StreamWriter(temporaryPath))
            {
                serializer.Serialize(textWriter, AmlObject);
            }
            Compressor.Compress(temporaryPath, outputFile, new string[0], overwriteFile);

            File.Delete(temporaryPath);
        }

        /// <summary>
        /// Deserializes the translation table and the input file. Then it checks the input file if it is valid.
        /// After that it starts the conversion process.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        private static void StartConversion(string inputFile, string outputFile)
        {
            Util.CheckGsdFileForCorrectness(inputFile);

            // Initialize the GSD XML documents and translation table. Then load these documents.
            var gsdDocument = Util.LoadXmlDocument(inputFile);
            var translationTable = Util.LoadTranslationsTable();

            if (translationTable.DocumentElement == null)
            {
                throw new XmlException("Could not load a XML file.");
            }

            // Add all conversion rules to a list.
            foreach (XmlNode node in translationTable.DocumentElement.ChildNodes)
            {
                TranslationRules.Add(node);
            }

            // Set FileName property of CAEX-element.
            AmlObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("FileName"))?.SetValue(AmlObject, new FileInfo(outputFile).Name);
            Util.Logger.Log(LogLevel.Info, "Added the FileName attribute to the CAEXFile element.");

            Util.Logger.Log(LogLevel.Info, "Start the Handle function.");
            Handle(gsdDocument.DocumentElement, AmlObject);
            Util.Logger.Log(LogLevel.Info, "Successfully ended the Hanlde function.");
        }

        /// <summary>
        /// Starts the real conversion process. It iterates over the GSD properties and translates it to AML.
        /// Then it recursiveley starts a new Handle call with the translated property.
        /// </summary>
        /// <typeparam name="TA">The type of the current AML head object.</typeparam>
        /// <param name="currentAmlHead">The current AML head object.</param>
        /// <param name="currentGsdHead">The current GSD head object as a XmlElement.</param>
        private static void Handle<TA>(XmlNode currentGsdHead, TA currentAmlHead)
        {
            Util.Logger.Log(LogLevel.Info, $"Started the Handle function with these heads. AML: {currentAmlHead.GetType().Name} GSD: {currentGsdHead.Name}");
            
            // Iterate over the properties of the current GSD parent.
            foreach (XmlNode gsdChildNode in currentGsdHead.ChildNodes)
            {
                Util.Logger.Log(LogLevel.Info, $"Current iterated GSD child node {gsdChildNode.Name}.");

                // Try to get a translation rule of the gsdTranslationElements list.
                var translationRule = TranslationRules.FirstOrDefault(node => node.Name.Equals(gsdChildNode.Name));
                // If the rule does not exist, it cannot be translated. It continues with the next property.
                if (translationRule == null)
                {
                    Util.Logger.Log(LogLevel.Info, "Translation rule was not found. Skip the node.");
                    continue;
                }
                Util.Logger.Log(LogLevel.Info, $"Translation rule was found. GsdHead: {currentGsdHead.Name} Translation rule: {translationRule.Name}" +
                                               "Now we are trying to translate it.");

                // Translate the gsdChildNode to AML.
                Translate(ref currentAmlHead, ref translationRule, out var newAmlHead);
                Util.Logger.Log(LogLevel.Info, $"Translated successfully {gsdChildNode.Name} to {translationRule["Replacement"]?.FirstChild.Name}.");

                // If the new AML head is an array, it calls for every element in the array the Handle function.
                if (newAmlHead.GetType().IsArray)
                {
                    Util.Logger.Log(LogLevel.Info, "The translated AML head is an array. Therefore for every element it calls the Handle function.");
                    foreach (var amlHeadElement in newAmlHead)
                    {
                        Handle(gsdChildNode, amlHeadElement);
                    }
                }
                else
                {
                    // Call the Handle function with the current gsdChildNode and the new AML head.
                    Util.Logger.Log(LogLevel.Info, "The translated AML is not an array. Therefore the Handle function will be directly called.");
                    Handle(gsdChildNode, newAmlHead);
                }
            }
            Util.Logger.Log(LogLevel.Info, $"The Handle function ended for these heads. AML: {currentAmlHead.GetType().Name} GSD: {currentGsdHead.Name}");
        }

        /// <summary>
        /// The actual translation of the GSD object to AML object.
        /// </summary>
        /// <typeparam name="TA">The type of the AML head object.</typeparam>
        /// <param name="currentAmlHead">The AML head object in which the translation object will be set.</param>
        /// <param name="translationRule">The translation rule which will be used to translate the GSD object to an AML object.</param>
        /// <param name="newAmlHead">An output parameter which will be set. It is at the end the new AML head object.</param>
        private static void Translate<TA>(ref TA currentAmlHead, ref XmlNode translationRule, out dynamic newAmlHead)
        {
            // Get information of the translation rule. (replacement and references)
            Util.Logger.Log(LogLevel.Info, $"Trying to get information out of the translation rule {translationRule.Name}.");
            Util.GetInformationFromRule(ref translationRule, out var replacement, out var references);
            Util.Logger.Log(LogLevel.Info, "Successfully got the information out of the translation rule.");

            // Get the AML replacement property.
            // Gets the type of the replacement property.
            // Gets variable which describes if the replacement property is an array.
            Util.Logger.Log(LogLevel.Info, $"Trying to get the property for {replacement.Name}.");
            Util.GetProperty(replacement.Name, out var replacementProperty, out var replacementPropertyType, out var isReplacementPropertyArray);
            Util.Logger.Log(LogLevel.Info, $"Successfully got the property for {replacement.Name}. " +
                                           $"Property: {replacementProperty} " +
                                           $"Type: {replacementPropertyType} " +
                                           $"Declaring type: {replacementProperty.DeclaringType} " +
                                           $"Is array: {isReplacementPropertyArray}");

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            dynamic replacementInstance = isReplacementPropertyArray
                                            ? Activator.CreateInstance(typeof(List<>).MakeGenericType(replacementPropertyType))
                                            : Activator.CreateInstance(replacementPropertyType);

            // Iterate over all sub properties of the replacement to translate these and set it into the replacementInstance.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                Util.Logger.Log(LogLevel.Info, $"Translate sub property {childNode.Name}.");
                var subProperty = TranslateSubProperties(childNode, out var subPropertyInstance);
                Util.Logger.Log(LogLevel.Info, $"Successfully translated {childNode.Name}. " +
                                               $"Type: {subPropertyInstance.GetType()}");

                if (isReplacementPropertyArray)
                {
                    replacementInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(replacementInstance, subPropertyInstance);
                }
                Util.Logger.Log(LogLevel.Info, $"Successfully set or added {childNode.Name} to {replacement.Name}.");
            }

            // Set the replacementInstance to the current AML head object and set the new AML head.
            newAmlHead = isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance;
            replacementProperty.SetValue(currentAmlHead, newAmlHead);
        }

        /// <summary>
        /// The translation of the sub properties of a translation rule.
        /// </summary>
        /// <param name="replacement">The XmlNode replacement rule.</param>
        /// <param name="translationInstance">The translation instance in which the sub property instances will be set.</param>
        /// <returns>The property info which describes the translationInstance.</returns>
        private static PropertyInfo TranslateSubProperties(XmlNode replacement, out dynamic translationInstance)
        {
            // Get the information of the replacement node. (PropertyInfo, isArray, Type)
            Util.GetProperty(replacement.Name, out var translationProperty, out var translationPropertyType, out var isTranslationPropertyArray);
            Util.Logger.Log(LogLevel.Info, $"Found valid property for {replacement.Name}. " +
                                           $"Property: {translationProperty} " +
                                           $"Type: {translationPropertyType} " +
                                           $"Declaring Type: {translationProperty.DeclaringType} " +
                                           $"Is array: {isTranslationPropertyArray}");

            // Create the translation instance.
            // If the translation Property is a string, it has to be handeled manually because it does not have a constructor with no parameters.
            if (translationPropertyType == typeof(string))
            {
                translationInstance = string.Empty;
            }
            else
            {
                translationInstance = isTranslationPropertyArray
                                        ? Activator.CreateInstance(typeof(List<>).MakeGenericType(translationPropertyType))
                                        : Activator.CreateInstance(translationPropertyType);
            }

            // Set attribute and inner text to the translation instance.
            if (translationInstance is string) translationInstance = replacement.InnerText;
            SetAttributes(ref replacement, ref translationInstance);
            Util.Logger.Log(LogLevel.Info, $"Successfully set attributes to {replacement.Name}.");

            // If the current node has only a text in it or no children it returns the translationProperty.
            if (replacement.SelectNodes("./*")?.Count == 0 || !replacement.HasChildNodes)
            {
                Util.Logger.Log(LogLevel.Info, $"The replacement {replacement.Name} does not have a children. Because of that the translation ends here.");
                if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();

                return translationProperty;
            }

            // Iterate over all child nodes of the current replacement rule.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                Util.Logger.Log(LogLevel.Info, $"Translate sub property {childNode.Name}");
                // Get the property info and the instance of the current child node.
                var subProperty = TranslateSubProperties(childNode, out var subPropertyInstance);
                Util.Logger.Log(LogLevel.Info, $"Successfully translated {childNode.Name}. " +
                                               $"Type: {subPropertyInstance.GetType()}");

                // Set or add the subPropertyInstance to the translationInstance.
                if (isTranslationPropertyArray)
                {
                    translationInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(translationInstance, subPropertyInstance);
                }
                Util.Logger.Log(LogLevel.Info, $"Successfully set or added {childNode.Name} to {replacement.Name}.");
            }

            if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();
            return translationProperty;
        }

        /// <summary>
        /// This function sets the attributes of a replacement node to the translation instance.
        /// This function assumes that all attributes are of type string. If not, then please contact the developers.
        /// </summary>
        /// <param name="replacement">The replacement node of the translation table which will be used to set those attributes to the instance.</param>
        /// <param name="translationInstance">The instance in which the attributes will be set.</param>
        ///  TODO: References implemention.
        private static void SetAttributes(ref XmlNode replacement, ref dynamic translationInstance)
        {
            // If there are not attributes, it is not possible to translate them.
            if (replacement.Attributes == null) return;

            // Iterate over all attributes.
            foreach (XmlAttribute attribute in replacement.Attributes)
            {
                // Get the property and type of the attribute.
                Util.GetProperty(attribute.Name, out var attributeProperty, out var attributePropertyType, out _);

                // Create the instance of the attribute and assume it is a string. If not, it throws a exception.
                dynamic attributeInstance;

                if (attributePropertyType == typeof(string))
                {
                    attributeInstance = attribute.Value;
                }
                else
                {
                    throw new InvalidDataException("Failed to translate attributes correctly due to incorrect typing.");
                }

                // Set the attribute instacne to the translation instance.
                attributeProperty.SetValue(translationInstance, attributeInstance);
            }
        }
    }
}
