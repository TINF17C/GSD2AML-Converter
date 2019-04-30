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
                    GsdObject = (ISO15745Profile)serializer.Deserialize(reader);
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
                throw new Exception("Could not load the translation table. Please contact the developers.");
            }

            // Add all conversion rules to a list.
            foreach (XmlNode node in translationTable.DocumentElement.ChildNodes)
            {
                GsdTranslationElements.Add(node);
            }

            // Set FileName property of CAEX-element.
            AmlObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("FileName"))?.SetValue(AmlObject, new FileInfo(outputFile).Name);

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

                // TODO: Remove this using block.
                using (var stringwriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(AmlObject.GetType());
                    serializer.Serialize(stringwriter, AmlObject);
                    Console.WriteLine(stringwriter.ToString());
                }

                Handle(gsdProperty.GetValue(currentGsdHead), newAmlHead);
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
            GetInformationFromRule(ref translationRule, out var replacement, out var references);
            
            // Get the AML replacement property.
            // Local variable which describes if the replacement property is an array.
            // Gets the type of the replacement property.
            GetTranslationInformation(ref replacement, out var replacementProperty, out var isReplacementPropertyArray, out var replacementPropertyType);

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

            // Set the replacementInstance to the current aml head object
            newAmlHead = replacementInstance;
            replacementProperty.SetValue(currentAmlHead, isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance);
        }

        // TODO: When migrating to .NET Core or .NET 7 use multiple return values instead of the out parameter.
        // TODO: Refactor this method.
        // TODO: Attribute and InnerText translation needs to be improved.
        private static PropertyInfo TranslateSubProperties(XmlNode replacement, out dynamic translationInstance)
        {
            // Get the information of the replacement node. (PropertyInfo, isArray, Type)
            GetTranslationInformation(ref replacement, out var translationProperty, out var isTranslationPropertyArray, out var translationPropertyType);
            if (replacement.Name.Equals("SystemUnitClassWrapper.SystemUnitClass")) Debugger.Break();
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

            // If the current node has only a text in it or no children it returns it.
            if (replacement.HasChildNodes && replacement.SelectNodes("./*")?.Count == 0 || !replacement.HasChildNodes)
            {
                if (translationInstance is string) translationInstance = replacement.InnerText;

                if (replacement.Attributes != null)
                {
                    foreach (XmlAttribute attribute in replacement.Attributes)
                    {
                        var attributeProperty = GetPropertyFromString(typeof(Wrapper), attribute.Name);
                        var isAttributePropertyArray = attributeProperty.PropertyType.IsArray;
                        var attributePropertyType = isAttributePropertyArray
                                                    ? attributeProperty.PropertyType.GetElementType()
                                                    : attributeProperty.PropertyType;
                        dynamic attributeInstance;

                        if (attributePropertyType == typeof(string))
                        {
                            attributeInstance = attribute.Value;
                        }
                        else
                        {
                            attributeInstance = isAttributePropertyArray
                                                ? Activator.CreateInstance(typeof(List<>).MakeGenericType(attributePropertyType))
                                                : Activator.CreateInstance(attributePropertyType);
                        }
                        attributeProperty.SetValue(translationInstance, attributeInstance);
                    }
                }
                return translationProperty;
            }

            foreach (XmlNode childNode in replacement.ChildNodes)
            {
                var subProperty = TranslateSubProperties(childNode, out var subPropertyInstance);

                subProperty.SetValue(translationInstance, subPropertyInstance);
            }

            return translationProperty;
        }

        /// <summary>
        /// This function sets the property information of a replacement node.
        /// </summary>
        /// <param name="replacement">The replacement node to a specific rule.</param>
        /// <param name="translationProperty">The translation property which will be set.</param>
        /// <param name="isTranslationPropertyArray">Boolean which will be set. It describes if the property is an array.</param>
        /// <param name="translationPropertyType">The translation property type which will be set.</param>
        private static void GetTranslationInformation(ref XmlNode replacement, out PropertyInfo translationProperty, out bool isTranslationPropertyArray, out Type translationPropertyType)
        {
            translationProperty = null;
            isTranslationPropertyArray = false;
            translationPropertyType = null;

            var splittedStrings = replacement.Name.Split('.').ToList();

            if (splittedStrings.Count == 1)
            {
                translationProperty = GetPropertyFromString(typeof(Wrapper), replacement.Name);
            }
            else
            {
                foreach (var splittedString in splittedStrings)
                {
                    translationProperty = GetPropertyFromString(translationProperty == null ? typeof(Wrapper) : translationProperty.PropertyType, splittedString);

                    if (translationProperty == null) return;
                }
            }

            if (translationProperty == null) return;

            isTranslationPropertyArray = translationProperty.PropertyType.IsArray;
            translationPropertyType = isTranslationPropertyArray
                                        ? translationProperty.PropertyType.GetElementType()
                                        : translationProperty.PropertyType;
        }

        /// <summary>
        /// This function gets the relevant information (replacement, references) from a translation rule.
        /// </summary>
        /// <param name="translationRule">The translation rule which will be parsed.</param>
        /// <param name="replacement">The actual replacement.</param>
        /// <param name="references">A list which will save all replacement.</param>
        private static void GetInformationFromRule(ref XmlNode translationRule, out XmlNode replacement, out ICollection<XmlNode> references)
        {
            var alreadyReadReplacement = false;
            references = new List<XmlNode>();
            replacement = null;

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
                            throw new Exception("Translation table has mutliple replacements for a rule. Please contact the developers.");
                        }
                        replacement = xmlNode.FirstChild;
                        alreadyReadReplacement = true;
                        break;
                    case "#comment": break;
                    default:
                        throw new Exception("Translation table has unknown element. Please contact the developers.");
                }
            }

            // Check if replacement is null.
            if (replacement != null) return;

            throw new Exception("Translation table has no replacement for a rule. Please contact the developers.");
        }

        /// <summary>
        /// Searches recursiveley a class down to find a property by a string.
        /// </summary>
        /// <param name="type">The type object which references the current iterated class.</param>
        /// <param name="propertyName">The name of the property which will be searched.</param>
        /// <returns>The property info object of the found property or null if it does not exist.</returns>
        private static PropertyInfo GetPropertyFromString(Type type, string propertyName)
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
                    // Check that the type is not a simple type and that the property is not the same as the current head property due to possible recurisve stackoverflow exception.
                    where !IsSimpleType(propertyType) && type != propertyType
                    // Recursive call of the current iterated property. If it is not null, it is the searched property.
                    select GetPropertyFromString(propertyType, propertyName)).FirstOrDefault(x => x != null);
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
                   System.Convert.GetTypeCode(type) != TypeCode.Object ||
                   (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0]));
        }
    }
}
