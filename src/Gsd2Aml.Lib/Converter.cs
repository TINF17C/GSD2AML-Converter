using Gsd2Aml.Lib.Logging;
using Gsd2Aml.Lib.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Gsd2Aml.Lib
{
    // TODO: References implemention.
    // TODO: translation table string dot handling
    // TODO: get ressources
    // TODO: timestamp
    public static class Converter
    {
        public static ILoggingService Logger { get; set; }

        private static CAEXFile AmlObject { get; } = new CAEXFile();

        private static List<XmlNode> TranslationRules { get; } = new List<XmlNode>();

        /// <summary>
        /// The convert function which returns the AML file as string.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <returns>The AML object serialized to a XML string.</returns>
        public static string Convert(string inputFile)
        {
            Logger?.Log(LogLevel.Info, "Conversion to string started.");
            StartConversion(inputFile, Util.GetOutputFileName(inputFile));

            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(AmlObject.GetType());
                serializer.Serialize(stringwriter, AmlObject);
                return stringwriter.ToString();
            }
        }

        /// <summary>
        /// The convert function which will create a .amlx file.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        public static void Convert(string inputFile, string outputFile, bool overwriteFile)
        {
            Logger?.Log(LogLevel.Info, "Conversion to file started.");
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
            Logger?.Log(LogLevel.Info, "Added the FileName attribute to the CAEXFile element.");

            Logger?.Log(LogLevel.Info, "Start the Handle function.");
            Handle(gsdDocument.DocumentElement, AmlObject);
            Logger?.Log(LogLevel.Info, "Successfully ended the Hanlde function.");
        }

        /// <summary>
        /// Starts the real conversion process. It iterates over the GSD properties and translates it to AML.
        /// Then it recursively starts a new Handle call with the translated property.
        /// </summary>
        /// <typeparam name="TA">The type of the current AML head object.</typeparam>
        /// <param name="currentAmlHead">The current AML head object.</param>
        /// <param name="currentGsdHead">The current GSD head object as a XmlElement.</param>
        private static void Handle<TA>(XmlNode currentGsdHead, TA currentAmlHead)
        {
            Logger?.Log(LogLevel.Info, $"Started the Handle function with these heads. AML: {currentAmlHead.GetType().Name} GSD: {currentGsdHead.Name}");
            
            // Iterate over the properties of the current GSD parent.
            foreach (XmlNode gsdChildNode in currentGsdHead.ChildNodes)
            {
                Logger?.Log(LogLevel.Info, $"Current iterated GSD child node {gsdChildNode.Name}.");

                // Try to get a translation rule of the gsdTranslationElements list.
                var translationRule = TranslationRules.FirstOrDefault(node => node.Name.Equals(gsdChildNode.Name));
                // If the rule does not exist, it cannot be translated. It continues with the next property.
                if (translationRule == null)
                {
                    Logger?.Log(LogLevel.Info, "Translation rule was not found. Skip the node.");
                    continue;
                }
                Logger?.Log(LogLevel.Info, $"Translation rule was found. GsdHead: {currentGsdHead.Name} Translation rule: {translationRule.Name}" +
                                               "Now we are trying to translate it.");

                // Translate the gsdChildNode to AML.
                var newAmlHead = Translate(ref currentAmlHead, translationRule);
                Logger?.Log(LogLevel.Info, $"Translated successfully {gsdChildNode.Name} to {translationRule["Replacement"]?.FirstChild.Name}.");

                // If the new AML head is an array, it calls for every element in the array the Handle function.
                if (newAmlHead.GetType().IsArray)
                {
                    Logger?.Log(LogLevel.Info, "The translated AML head is an array. Therefore for every element it calls the Handle function.");
                    foreach (var amlHeadElement in newAmlHead)
                    {
                        Handle(gsdChildNode, amlHeadElement);
                    }
                }
                else
                {
                    // Call the Handle function with the current gsdChildNode and the new AML head.
                    Logger?.Log(LogLevel.Info, "The translated AML is not an array. Therefore the Handle function will be directly called.");
                    Handle(gsdChildNode, newAmlHead);
                }
            }
            Logger?.Log(LogLevel.Info, $"The Handle function ended for these heads. AML: {currentAmlHead.GetType().Name} GSD: {currentGsdHead.Name}");
        }

        /// <summary>
        /// The actual translation of the GSD object to AML object.
        /// </summary>
        /// <typeparam name="TA">The type of the AML head object.</typeparam>
        /// <param name="currentAmlHead">The AML head object in which the translation object will be set.</param>
        /// <param name="translationRule">The translation rule which will be used to translate the GSD object to an AML object.</param>
        /// <returns>Return value is the new AML head object.</returns>
        private static dynamic Translate<TA>(ref TA currentAmlHead, XmlNode translationRule)
        {
            // Get information of the translation rule. (replacement and references)
            var (replacement, references) = Util.GetInformationFromRule(translationRule);

            // Get the information fo the replacement node. (PropertyInfo, Type, isArray)
            var (replacementProperty, replacementPropertyType, isReplacementPropertyArray) = Util.GetProperty(replacement.Name);

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            var replacementInstance = Util.CreateInstance(replacementPropertyType, isReplacementPropertyArray);

            AddSubInstancesToInstance(replacement, replacementInstance, isReplacementPropertyArray);

            // Set the replacementInstance to the current AML head object and set the new AML head.
            var newAmlHead = isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance;
            replacementProperty.SetValue(currentAmlHead, newAmlHead);

            return newAmlHead;
        }

        /// <summary>
        /// The translation of the sub properties of a translation rule.
        /// </summary>
        /// <param name="replacement">The XmlNode replacement rule.</param>
        /// <returns>The property info which describes the translationInstance and the translation instance in which the sub property instances will be set.</returns>
        private static (PropertyInfo, dynamic) TranslateSubProperties(XmlNode replacement)
        {
            // Get the information of the replacement node. (PropertyInfo, Type, isArray)
            var (translationProperty, translationPropertyType, isTranslationPropertyArray) = Util.GetProperty(replacement.Name);

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            var translationInstance = Util.CreateInstance(translationPropertyType, isTranslationPropertyArray);
            
            // Set attribute and inner text to the translation instance.
            if (translationInstance is string) translationInstance = replacement.InnerText;
            SetAttributes(replacement, translationInstance);
            Logger?.Log(LogLevel.Info, $"Successfully set attributes to {replacement.Name}.");

            // If the current node has only a text in it or no children it returns the translationProperty.
            if (replacement.SelectNodes("./*")?.Count == 0 || !replacement.HasChildNodes)
            {
                Logger?.Log(LogLevel.Info, $"The replacement {replacement.Name} does not have a children. Because of that the translation ends here.");
                if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();

                return (translationProperty, translationInstance);
            }

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            AddSubInstancesToInstance(replacement, translationInstance, isTranslationPropertyArray);

            if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();
            return (translationProperty, translationInstance);
        }

        /// <summary>
        /// This function sets the attributes of a replacement node to the translation instance.
        /// This function assumes that all attributes are of type string. If not, then please contact the developers.
        /// </summary>
        /// <param name="replacement">The replacement node of the translation table which will be used to set those attributes to the instance.</param>
        /// <param name="translationInstance">The instance in which the attributes will be set.</param>
        private static void SetAttributes(XmlNode replacement, dynamic translationInstance)
        {
            // If there are not attributes, it is not possible to translate them.
            if (replacement.Attributes == null) return;

            // Iterate over all attributes.
            foreach (XmlAttribute attribute in replacement.Attributes)
            {
                // Get the property and type of the attribute.
                var (attributeProperty, attributePropertyType, _) = Util.GetProperty(attribute.Name);
                

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

                // Set the attribute instance to the translation instance.
                attributeProperty.SetValue(translationInstance, attributeInstance);
            }
        }

        /// <summary>
        /// This function iterates over all sub properties of the replacement to translate these and set it into the replacementInstance.
        /// </summary>
        /// <param name="replacement">The replacement rule.</param>
        /// <param name="replacementInstance">The replacement instance in which the sub properties will be set.</param>
        /// <param name="isReplacementPropertyArray">A flag which indicates whether the current instance is an array or not.</param>
        private static void AddSubInstancesToInstance(XmlNode replacement, dynamic replacementInstance, bool isReplacementPropertyArray)
        {
            // Iterate over all sub properties of the replacement to translate these and set it into the replacementInstance.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                Logger?.Log(LogLevel.Info, $"Translate sub property {childNode.Name}.");
                var (subProperty, subPropertyInstance) = TranslateSubProperties(childNode);
                Logger?.Log(LogLevel.Info, $"Successfully translated {childNode.Name}. " +
                                                $"Type: {subPropertyInstance.GetType()}");

                if (isReplacementPropertyArray)
                {
                    replacementInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(replacementInstance, subPropertyInstance);
                }
                Logger?.Log(LogLevel.Info, $"Successfully set or added {childNode.Name} to {replacement.Name}.");
            }
        }
    }
}
