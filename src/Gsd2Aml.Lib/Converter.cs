using System;
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
    /// <summary>
    /// The converter class which contains the logic to convert a GSD formatted file to an AML file.
    /// </summary>
    public static class Converter
    {
        public static ILoggingService Logger { get; set; }

        private static CAEXFile AmlObject { get; } = new CAEXFile();

        private static List<XmlNode> TranslationRules { get; } = new List<XmlNode>();

        internal static XmlDocument GsdDocument { get; set; }

        /// <summary>
        /// Converts a GSDML input file and returns the resulting AML file as a string.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="strictValidation">A flag which indicates if the GSD should be checked for correctness.</param>
        /// <returns>The AML object serialized to a XML string.</returns>
        public static string Convert(string inputFile, bool strictValidation = true)
        {
            Util.RelativeGsdFilePath = "/" + Path.GetFileName(inputFile);

            Logger?.Log(LogLevel.Info, "Conversion to string started.");
            StartConversion(inputFile, Util.GetOutputFileName(inputFile), strictValidation);

            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(AmlObject.GetType());
                serializer.Serialize(stringwriter, AmlObject);
                return stringwriter.ToString();
            }
        }

        /// <summary>
        /// Converts a GSDML input file and creates the .amlx package.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        /// <param name="strictValidation">A flag which indicates if the GSD should be checked for correctness.</param>
        public static void Convert(string inputFile, string outputFile, bool overwriteFile, bool strictValidation = true)
        {
            Util.RelativeGsdFilePath = Path.GetFileName(inputFile);

            Logger?.Log(LogLevel.Info, "Conversion to file started.");
            StartConversion(inputFile, outputFile, strictValidation);

            var serializer = new XmlSerializer(AmlObject.GetType());
            var temporaryPath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(outputFile) + ".aml");

            using (var textWriter = new StreamWriter(temporaryPath))
            {
                serializer.Serialize(textWriter, AmlObject);
            }

            var resources = new List<string> {inputFile};

            foreach (XmlNode xmlNode in Util.IterateThroughGsdDocument(Util.CGraphicPath).GetElementsByTagName(Util.CRealGraphicName))
            {
                var xmlNodeAttributes = xmlNode.Attributes;
                var file = xmlNodeAttributes?[Util.CRealValueGraphicName].Value;
                file += string.IsNullOrEmpty(Path.GetExtension(file)) ? ".bmp" : string.Empty;
                resources.Add(Path.Combine(Path.GetDirectoryName(inputFile) ?? throw new InvalidOperationException("Invalid input file path."), file));
            }

            Compressor.Compress(temporaryPath, outputFile, resources.ToArray(), overwriteFile);

            File.Delete(temporaryPath);
        }

        /// <summary>
        /// Deserializes the translation table and the input file. Then it checks the input file for validity.
        /// After that it starts the conversion process.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="strictValidation">A flag which indicates if the GSDML should be checked for correctness.</param>
        private static void StartConversion(string inputFile, string outputFile, bool strictValidation)
        {
            if (strictValidation) Util.CheckGsdFileForCorrectness(inputFile);

            // Load the GSD and the translation table XML document.
            GsdDocument = Util.LoadXmlDocument(inputFile);
            var translationTable = Util.LoadTranslationTable();

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
            Logger?.Log(LogLevel.Debug, "Added the FileName attribute to the CAEXFile element.");

            Logger?.Log(LogLevel.Info, "Start the Handle function.");
            Handle(GsdDocument.DocumentElement, AmlObject);
            Logger?.Log(LogLevel.Info, "Successfully ended the Handle function.");
        }

        /// <summary>
        /// Starts the real conversion process.
        /// It iterates over the GSDML properties and translates it to AML.
        /// Then it recursively starts a new Handle call with the translated property.
        /// </summary>
        /// <typeparam name="TA">The type of the current AML head object.</typeparam>
        /// <param name="currentAmlHead">The current AML head object.</param>
        /// <param name="currentGsdHead">The current GSD head object as a XmlElement.</param>
        private static void Handle<TA>(XmlNode currentGsdHead, TA currentAmlHead)
        {
            Logger?.Log(LogLevel.Debug, $"Started the Handle function with these heads. GSD: {currentGsdHead.Name} AML: {currentAmlHead.GetType().Name}");
            
            // Iterate over the properties of the current GSD parent.
            foreach (XmlNode gsdChildNode in currentGsdHead.ChildNodes)
            {
                Logger?.Log(LogLevel.Debug, $"Current iterated GSD child node {gsdChildNode.Name}.");

                // Try to get a translation rule of the gsdTranslationElements list.
                var translationRule = TranslationRules.FirstOrDefault(node => node.Name.Equals(gsdChildNode.Name));
                // If the rule does not exist, it cannot be translated. It continues with the next property.
                if (translationRule == null)
                {
                    Logger?.Log(LogLevel.Debug, $"Translation rule for {gsdChildNode.Name} was not found. Skip the node.");
                    continue;
                }
                Logger?.Log(LogLevel.Debug, $"Translation rule was found for {gsdChildNode.Name}. Now we are trying to translate it.");
                
                // Translate the gsdChildNode to AML.
                var newAmlHead = Translate(ref currentAmlHead, translationRule);
                Logger?.Log(LogLevel.Info, $"Translated successfully {gsdChildNode.Name} to {translationRule["Replacement"]?.FirstChild.Name}.");

                // If the new AML head is an array, it calls for every element in the array the Handle function.
                if (newAmlHead.GetType().IsArray)
                {
                    Logger?.Log(LogLevel.Debug, "The translated AML head is an array. Therefore for every element it calls the Handle function.");
                    foreach (var amlHeadElement in newAmlHead)
                    {
                        Handle(gsdChildNode, amlHeadElement);
                    }
                }
                else
                {
                    // Call the Handle function with the current gsdChildNode and the new AML head.
                    Logger?.Log(LogLevel.Debug, "The translated AML is not an array. Therefore the Handle function will be directly called.");
                    Handle(gsdChildNode, newAmlHead);
                }
            }
            Logger?.Log(LogLevel.Info, $"The Handle function ended for these heads. AML: {currentAmlHead.GetType().Name} GSD: {currentGsdHead.Name}");
        }

        /// <summary>
        /// The actual translation of the GSD object to an AML object.
        /// </summary>
        /// <typeparam name="TA">The type of the AML head object.</typeparam>
        /// <param name="currentAmlHead">The AML head object in which the translation object will be set.</param>
        /// <param name="translationRule">The translation rule which will be used to translate the GSD object to an AML object.</param>
        /// <returns>The new AML head object.</returns>
        private static dynamic Translate<TA>(ref TA currentAmlHead, XmlNode translationRule)
        {
            // Get information of the translation rule. (replacement and references)
            var (replacement, references, _) = Util.GetInformationFromRule(translationRule);

            // Get the information fo the replacement node. (PropertyInfo, Type, isArray)
            var (replacementProperty, replacementPropertyType, isReplacementPropertyArray) = Util.GetProperty(replacement.Name);

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            var replacementInstance = Util.CreateInstance(replacementPropertyType, isReplacementPropertyArray);
            SetAttributes(replacement, replacementInstance, references);
            AddSubInstancesToInstance(replacement, replacementInstance, isReplacementPropertyArray, references);

            // Set the replacementInstance to the current AML head object and set the new AML head.
            var newAmlHead = isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance;
            replacementProperty.SetValue(currentAmlHead, newAmlHead);

            return newAmlHead;
        }

        /// <summary>
        /// This function iterates over all sub properties of the replacement to translate these and set them into the replacementInstance.
        /// </summary>
        /// <param name="replacement">The replacement rule.</param>
        /// <param name="replacementInstance">The replacement instance in which the sub properties will be set.</param>
        /// <param name="isReplacementPropertyArray">A flag which indicates whether the current instance is an array or not.</param>
        /// <param name="references">Dictionary which contains information about the references.</param>
        private static void AddSubInstancesToInstance(XmlNode replacement, dynamic replacementInstance, bool isReplacementPropertyArray, Dictionary<string, string> references)
        {
            // Iterate over all sub properties of the replacement to translate these and set it into the replacementInstance.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                if (childNode.Name.Equals("#comment")) continue;
                if (childNode.Name.Equals("Rule"))
                {
                    HandleRuleCall(childNode, replacementInstance);
                    continue;
                }

                Logger?.Log(LogLevel.Info, $"Translate sub property {childNode.Name}.");
                var (subProperty, subPropertyInstance) = TranslateSubProperties(childNode, references);
                Logger?.Log(LogLevel.Debug, $"Successfully translated {childNode.Name}.");

                if (isReplacementPropertyArray)
                {
                    replacementInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(replacementInstance, subPropertyInstance);
                }
                Logger?.Log(LogLevel.Debug, $"Successfully set or added {childNode.Name} to {replacement.Name}.");
            }
        }

        /// <summary>
        /// This function handles a new Rule call in the translation table.
        /// It takes the inner text of the rule node and translate it with the corresponding rule.
        /// </summary>
        /// <param name="childNode">The rule node which contains the information which rule should be applied.</param>
        /// <param name="replacementInstance">The instance in which the rule instance will be set/added.</param>
        private static void HandleRuleCall(XmlNode childNode, dynamic replacementInstance)
        { 
            // Get the translation rule
            var translationRule = TranslationRules.FirstOrDefault(node => node.Name.Equals(childNode.InnerText));

            if (translationRule == null)
            {
                Logger?.Log(LogLevel.Debug, $"Translation rule for {childNode.Name} was not found. Skip the node.");
                return;
            }

            var lastNode = Util.IterateThroughGsdDocument(translationRule.Name);
            if (lastNode == null)
            {
                Logger?.Log(LogLevel.Warning, $"Failed to iterate thorugh a rule path. {translationRule.Name}");
                // throw new InvalidDataException("Failed to handle a rule call in translation table.");
            }

            var preLastnode = (XmlElement) lastNode.ParentNode;
            var (ruleReplacement, _, refList) = Util.GetInformationFromRule(translationRule);
            var nodeList = preLastnode?.GetElementsByTagName(lastNode.Name);

            if (nodeList == null)
            {
                Logger?.Log(LogLevel.Error, $"Could not create a list out of {lastNode.Name}.");
                throw new InvalidDataException("Could not create a list out of a rule call in translation table.");
            }

            foreach (XmlNode node in nodeList)
            {
                var ruleReferences = Util.ParseReferences(refList, node);
                var (_, ruleReplacementPropertyType, isRuleReplacementPropertyArray) = Util.GetProperty(ruleReplacement.Name);
                var ruleReplacementInstance = Util.CreateInstance(ruleReplacementPropertyType, isRuleReplacementPropertyArray);
                SetAttributes(ruleReplacement, ruleReplacementInstance, ruleReferences);
                AddSubInstancesToInstance(ruleReplacement, ruleReplacementInstance, isRuleReplacementPropertyArray, ruleReferences);
                replacementInstance.Add(ruleReplacementInstance);
            }
        }

        /// <summary>
        /// Translates the sub properties of a translation rule.
        /// </summary>
        /// <param name="replacement">The XmlNode replacement rule.</param>
        /// <param name="references">Dictionary which contains information about the references of a rule.</param>
        /// <returns>The property info which describes the translationInstance and the translation instance in which the sub property instances will be set.</returns>
        private static (PropertyInfo, dynamic) TranslateSubProperties(XmlNode replacement, Dictionary<string, string> references)
        {
            // Get the information of the replacement node. (PropertyInfo, Type, isArray)
            var (translationProperty, translationPropertyType, isTranslationPropertyArray) = Util.GetProperty(replacement.Name);

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            var translationInstance = Util.CreateInstance(translationPropertyType, isTranslationPropertyArray);
            
            // Set attribute and inner text to the translation instance.
            if (translationInstance is string || replacement.Name.Equals("Attribute.Value"))
            {
                if (replacement.InnerText.Contains('$') && references.ContainsKey(replacement.InnerText))
                {
                    translationInstance = references[replacement.InnerText];
                }
                else if (replacement.InnerText.Contains('$') && !references.ContainsKey(replacement.InnerText))
                {
                    translationInstance = string.Empty;
                }
                else
                {
                    translationInstance = replacement.InnerText;
                }
            }
            SetAttributes(replacement, translationInstance, references);
            Logger?.Log(LogLevel.Debug, $"Successfully set attributes to {replacement.Name}.");

            // If the current node has only a text in it or no children it returns the translationProperty.
            if (replacement.SelectNodes("./*")?.Count == 0 || !replacement.HasChildNodes)
            {
                Logger?.Log(LogLevel.Debug, $"The replacement {replacement.Name} does not have a children. Because of that the translation ends here.");
                if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();

                return (translationProperty, translationInstance);
            }

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            AddSubInstancesToInstance(replacement, translationInstance, isTranslationPropertyArray, references);

            if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();
            return (translationProperty, translationInstance);
        }

        /// <summary>
        /// This function sets the attributes of a replacement node to the translation instance.
        /// This function assumes that all attributes are of type string.
        /// If not, then please contact the developers <see href="https://github.com/TINF17C/GSD2AML-Converter"/>.
        /// </summary>
        /// <param name="replacement">The replacement node of the translation table which will be used to set those attributes to the instance.</param>
        /// <param name="translationInstance">The instance in which the attributes will be set.</param>
        /// <param name="references">Dictionary which contains information about the references of a rule.</param>
        private static void SetAttributes(XmlNode replacement, dynamic translationInstance, IReadOnlyDictionary<string, string> references)
        {
            // If there are not attributes, it is not possible to translate them.
            if (replacement.Attributes == null) return;

            // Iterate over all attributes.
            foreach (XmlAttribute attribute in replacement.Attributes)
            {
                // Get the property and type of the attribute.
                var (attributeProperty, attributePropertyType, _) = Util.GetProperty(attribute.Name);
                
                // Create the instance of the attribute and assume it is a string. If not, it throws a exception.
                dynamic attributeInstance = null;

                if (attribute.Name.Contains("ID")) attributeInstance = Guid.NewGuid().ToString();

                if (attributePropertyType == typeof(string))
                {
                    if (attribute.Value.Contains('$') && references.ContainsKey(attribute.Value))
                    {
                        attributeInstance = references[attribute.Value];
                    }
                    else if (attribute.Value.Contains('$') && !references.ContainsKey(attribute.Value))
                    {
                        attributeInstance = string.Empty;
                    }
                    else if (attributeInstance == null)
                    {
                        attributeInstance = attribute.Value;
                    }
                }
                else
                {
                    throw new InvalidDataException("Failed to translate attributes correctly due to incorrect typing.");
                }

                // Set the attribute instance to the translation instance.
                attributeProperty.SetValue(translationInstance, attributeInstance);
            }
        }
    }
}
