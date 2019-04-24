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
                    Util.Logger.Log(LogLevel.Error, e.Message);
                    Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                    throw new Exception("Invalid GSD-file. Failed to serialize the GSD-File.");
                }
            }

            // Load translation table.
            translationTable.Load(CTranslationTableFileName);

            if (translationTable.DocumentElement == null)
            {
                Util.Logger.Log(LogLevel.Error, "Could not load the translation table.");
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
        /// <typeparam name="TA">The type of the current AML head object.</typeparam>
        /// <typeparam name="TG">The type of the current GSD head object.</typeparam>
        /// <param name="amlParent">The current AML head object.</param>
        /// <param name="gsdParent">The current GSD head object.</param>
        private static void Handle<TG, TA>(TG gsdParent, TA amlParent)
        {
            // If the current GSD parent is null, it does not make any sense to iterate over its properties.
            if (gsdParent == null)
            {
                return;
            }

            // Iterate over the properties of the current GSD parent.
            foreach (var gsdProperty in gsdParent.GetType().GetProperties())
            {
                // Check if the current iterated property is null. If yes, it cannot be translated and it continues with the next property.
                if (gsdProperty.GetValue(gsdParent) == null)
                {
                    continue;
                }

                // Get the translation rule of the gsdTranslationElements list.
                var translationRule = GsdTranslationElements.FirstOrDefault(node => node.Name.Equals(gsdProperty.Name));
                // If the rule does not exist, it cannot be translated. It continues with the next property.
                if (translationRule == null) continue;

                // Get the instance of the current iterated property and translate it.
                var gsdPropertyInstance = gsdProperty.GetValue(gsdParent);
                Translate(gsdPropertyInstance, amlParent, translationRule);

                // TODO: Call Handle function

                using (var stringwriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(AmlObject.GetType());
                    serializer.Serialize(stringwriter, AmlObject);
                    Console.WriteLine(stringwriter.ToString());
                };
                Console.WriteLine("\n\n");
            }
        }

        /// <summary>
        /// The actual translation of the GSD object to AML object.
        /// </summary>
        /// <typeparam name="TG">The type of the GSD object which will be translated.</typeparam>
        /// <param name="gsdObject">The GSD object which will be translated.</param>
        /// <param name="translationRule">The translation rule which will be used to translate the GSD object to an AML object.</param>
        private static void Translate<TG, TA>(TG gsdObject, TA amlObject, XmlNode translationRule)
        {
            // Create variables for references and replacements.
            XmlNode replacement = null;
            var references = new List<XmlNode>();

            // Get information of the translation rule.
            GetInformationFromRule(translationRule, ref replacement, references);

            // Get the replacement property.
            var replacementProperty = GetPropertyFromString(AmlObject.GetType(), replacement.Name);
            // Local variable which describes if the replacment property is an array.
            var isReplacementPropertyArray = replacementProperty.PropertyType.IsArray;
            // Gets the type of the replacement property.
            var replacementPropertyType = isReplacementPropertyArray
                                            ? replacementProperty.PropertyType.GetElementType()
                                            : replacementProperty.PropertyType;

            if (replacementPropertyType == null) return;

            // Create replacement instance. If the replacement is an array then create a list. If not then a normal instance.
            dynamic replacementInstance = isReplacementPropertyArray 
                                        ? Activator.CreateInstance(typeof(List<>).MakeGenericType(replacementPropertyType))
                                        : Activator.CreateInstance(replacementPropertyType);

            Console.WriteLine(replacement.Name);

            // Set the replacement to the aml object.
            replacementProperty.SetValue(amlObject, isReplacementPropertyArray ? replacementInstance.ToArray() : replacementInstance);
        }

        /// <summary>
        /// This function gets the relevant information (replacement, references) of a translation rule.
        /// </summary>
        /// <param name="translationRule">The translation rule which will be parsed.</param>
        /// <param name="replacement">The actual replacement.</param>
        /// <param name="references">A list which will save all replacement.</param>
        private static void GetInformationFromRule(XmlNode translationRule, ref XmlNode replacement, ICollection<XmlNode> references)
        {
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
                            Util.Logger.Log(LogLevel.Error, "Translation table has a syntactic error. A rule has more than one replacement.");
                            throw new Exception("Translation table has mutliple replacements for a rule. Please contact the developers.");
                        }
                        replacement = xmlNode.FirstChild;
                        alreadyReadReplacement = true;
                        break;
                    default:
                        Util.Logger.Log(LogLevel.Error, "Translation table has a syntactic error. There is an unknown element.");
                        throw new Exception("Translation table has unknown element. Please contact the developers.");
                }
            }

            // Check if replacement is null.
            if (replacement != null) return;

            Util.Logger.Log(LogLevel.Error, "Translation table has a syntacitc error. There is no replacement for a rule.");
            throw new Exception("Translation table has no replacement for a rule. Please contact the developers.");
        }

        /// <summary>
        /// Searches recursivley a class down to find a property by a string.
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
