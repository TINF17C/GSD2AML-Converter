using System.IO;
using Gsd2Aml.Lib.Models;
using System.Xml.Serialization;

namespace Gsd2Aml.Lib
{
    public class Converter
    {
        private readonly string CInputFile;
        private readonly string COutputFile;
        private readonly bool CStringOutput;

        public Converter(string inputFile, string outputFile, bool stringOutput)
        {
            this.CInputFile = inputFile;
            this.COutputFile = outputFile;
            this.CStringOutput = stringOutput;
        }

        public void Convert()
        {
            var serializer = new XmlSerializer(typeof(ISO15745Profile));

            using (var reader = new FileStream(CInputFile, FileMode.Open))
            {
                serializer.Deserialize(reader);
            }
        }
    }
}
