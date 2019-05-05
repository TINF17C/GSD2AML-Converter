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
    public static class Converter
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
        /// <param name="stringOutput">A boolean whether a file output or a string output should be returned.</param>
        public static void Convert(string inputFile, string outputFile, bool stringOutput)
        {
            var serializer = new XmlSerializer(typeof(ISO15745Profile));
            var translationTable = new XmlDocument();

            // Deserialize the GSD-file.
            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                try
                {
                    GsdObject = (ISO15745Profile) serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    throw new Exception("Invalid GSD-file. Failed to serialize the GSD-File.", e);
                }
            }

            // Load translation table.
            translationTable.Load(CTranslationTableFileName);

            if (translationTable.DocumentElement == null)
            {
                throw new Exception("Could not load the translation table.");
            }

            // Add all conversion rules to a list.
            foreach (XmlNode node in translationTable.DocumentElement.ChildNodes)
            {
                GsdTranslationElements.Add(node);
            }

            // Set FileName property of CAEX-element.
            AmlObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("FileName"))
                ?.SetValue(AmlObject, new FileInfo(outputFile).Name);

            Handle(GsdObject, AmlObject);
        }

        /// <summary>
        /// Starts the real conversion process. It iterates over the GSD properties and translates it to AML.
        /// Then it recursiveley starts a new Handle call with the translated property.
        /// </summary>
        /// <typeparam name="TG">The type of the current GSD head object.</typeparam>
        /// <typeparam name="TA">The type of the current AML head object.</typeparam>
        /// <param name="currentAmlHead">The current AML head object.</param>
        /// <param name="currentGsdHead">The current GSD head object.</param>
        private static void Handle<TG, TA>(TG currentGsdHead, TA currentAmlHead)
        {
            // If the current GSD parent is null, it does not make any sense to iterate over its properties.
            if (currentGsdHead == null)
            {
                return;
            }

            // Iterate over the properties of the current GSD parent.
            foreach (var gsdProperty in currentGsdHead.GetType().GetProperties())
            {
                // Check if the current iterated property is null. If yes, it cannot be translated and it continues with the next property.
                if (gsdProperty.GetValue(currentGsdHead) == null)
                {
                    continue;
                }

                // Get the translation rule of the gsdTranslationElements list.
                var translationRule = GsdTranslationElements.FirstOrDefault(node => node.Name.Equals(gsdProperty.Name));
                // If the rule does not exist, it cannot be translated. It continues with the next property.
                if (translationRule == null) continue;

                // Translate the gsdProperty to AML.
                Translate(ref currentAmlHead, ref translationRule, out var newAmlHead);

                // If the new aml head is an array, it calls for every element in the array the Handle function.
                if (newAmlHead.GetType().IsArray)
                {
                    foreach (var amlHeadElement in newAmlHead)
                    {
                        Handle(gsdProperty.GetValue(currentGsdHead), amlHeadElement);
                    }
                }
                else
                {
                    // Call the Handle function with the current gsdProperty and the new AML head.
                    Handle(gsdProperty.GetValue(currentGsdHead), newAmlHead);
                }
            }

            // TODO: Remove this using block.
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(AmlObject.GetType());
                serializer.Serialize(stringwriter, AmlObject);
                Console.WriteLine(stringwriter + "\n");
            }
        }

        /// <summary>
        /// The actual translation of the GSD object to AML object.
        /// </summary>
        /// <typeparam name="TA">The type of the AML parent object.</typeparam>
        /// <param name="currentAmlHead">The AML parent object in which the translation object will be set.</param>
        /// <param name="translationRule">The translation rule which will be used to translate the GSD object to an AML object.</param>
        /// <param name="newAmlHead">An output parameter which will be set. It is at the end the new aml head object.</param>
        private static void Translate<TA>(ref TA currentAmlHead, ref XmlNode translationRule, out dynamic newAmlHead)
        {
            newAmlHead = null;

            // Get information of the translation rule. (replacement and references)
            Util.GetInformationFromRule(ref translationRule, out var replacement, out var references);

            // Get the AML replacement property.
            // A local variable which describes if the replacement property is an array.
            // Gets the type of the replacement property.
            Util.GetProperty(replacement.Name, out var replacementProperty, out var replacementPropertyType, out var isReplacementPropertyArray);

            if (replacementPropertyType == null) return;

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            dynamic replacementInstance = isReplacementPropertyArray
                ? Activator.CreateInstance(typeof(List<>).MakeGenericType(replacementPropertyType))
                : Activator.CreateInstance(replacementPropertyType);

            // Iterate over all sub properties of the replacement to translate these and set it into the replacementInstance.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                var subProperty = TranslateSubProperties(childNode, out var subPropertyInstance);

                if (isReplacementPropertyArray)
                {
                    replacementInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(replacementInstance, subPropertyInstance);
                }
            }

            // Set the replacementInstance to the current AML head object and set the new AML head.
            newAmlHead = isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance;
            replacementProperty.SetValue(currentAmlHead, newAmlHead);
        }

        // TODO: When migrating to .NET Core or .NET 7 use multiple return values instead of the out parameter.
        private static PropertyInfo TranslateSubProperties(XmlNode replacement, out dynamic translationInstance)
        {
            // Get the information of the replacement node. (PropertyInfo, isArray, Type)
            Util.GetProperty(replacement.Name, out var translationProperty, out var translationPropertyType, out var isTranslationPropertyArray);

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

            // If the current node has only a text in it or no children it returns the translationProperty.
            if (replacement.SelectNodes("./*")?.Count == 0 || !replacement.HasChildNodes)
            {
                if (isTranslationPropertyArray) translationInstance = translationInstance.ToArray();

                return translationProperty;
            }

            // Iterate over all child nodes of the current replacement rule.
            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                // Get the property info and the instance of the current child node.
                var subProperty = TranslateSubProperties(childNode, out var subPropertyInstance);

                // Set or add the subPropertyInstance to the translationInstance.
                if (isTranslationPropertyArray)
                {
                    translationInstance.Add(subPropertyInstance);
                }
                else
                {
                    subProperty.SetValue(translationInstance, subPropertyInstance);
                }
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
                Util.GetProperty(attribute.Name, out var attributeProperty, out var attributePropertyType, out var isAttributePropertyArray);

                // Create the instance of the attribute and assume it is a string. If not, it throws a exception.
                dynamic attributeInstance;

                if (attributePropertyType == typeof(string))
                {
                    attributeInstance = attribute.Value;
                }
                else
                {
                    throw new Exception("Failed to translate attributes correctly due to incorrect typing.");
                }

                // Set the attribute instacne to the translation instance.
                attributeProperty.SetValue(translationInstance, attributeInstance);
            }
        }
    }
}
