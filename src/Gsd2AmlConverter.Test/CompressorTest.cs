using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Compression;
using System.Diagnostics;

namespace Gsd2AmlConverter.Test
{
    [TestClass]
    public class CompressorTest
    {
        /// <summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestCompressor()
        {
            string testDir = new Uri(System.IO.Path
                .Combine(new Uri(Assembly.GetExecutingAssembly().CodeBase)
                .AbsolutePath, @"..\..\..\..\..\tst"))
                .LocalPath;

            const string amlFileName = "aml.xml";

            var res = Directory.GetFiles(testDir).Where((f) => !Path.GetFileName(f).Equals(amlFileName)).ToArray();
            var amlFile = Directory.GetFiles(testDir).Where((f) => Path.GetFileName(f).Equals(amlFileName)).First();

            var compressor = new Compressor();

            var finalAMLXFile = compressor.Compress(amlFile, testDir, "myAmlx.amlx", res);

            using (var archive = ZipFile.OpenRead(finalAMLXFile))
            {
                foreach (var entry in archive.Entries)
                {
                    if (!entry.Name.Equals(amlFileName) &&
                        !res.Any(f => Path.GetFileName(f).Equals(entry.Name)))
                    {
                        throw new ArgumentException($"We found {entry.Name}, which was not expected.");
                    }
                }
                foreach (var fileName in res.Select(f => Path.GetFileName(f)))
                {
                    if (!archive.Entries.Any((f) => f.Equals(fileName)))
                    {
                        throw new ArgumentException($"We are missing {fileName} in the ZIP-archive.");
                    }

                }
            }

            try
            {
                File.Delete(finalAMLXFile);
            }
            catch
            {
                throw;
            }
        }
    }
}
