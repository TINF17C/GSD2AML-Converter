using System;
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

            translationTable.Load(CTranslationTableFileName);

            if (translationTable.DocumentElement == null)
            {
                Util.Logger.Log(LogLevel.Error, "Could not load the translation table.");
                throw new Exception("Could not load the translation table. Please contact the developers.");
            }

            AmlObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("FileName"))?.SetValue(AmlObject, new FileInfo(outputFile).Name);

            foreach (XmlNode node in translationTable.DocumentElement.ChildNodes)
            {
                ConvertElement(node);
            }
        }

        private static void ConvertElement(XmlNode xmlNode)
        {
            var gsdElement = FindGsdElement(xmlNode.Name);

        }

        private static PropertyInfo FindGsdElement(string elementName)
        {
            return GsdObject.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals(elementName));
        }
    }
}
