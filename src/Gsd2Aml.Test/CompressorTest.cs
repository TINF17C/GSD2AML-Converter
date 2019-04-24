using Gsd2Aml.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace Gsd2Aml.Test
{
    [TestClass]
    public class CompressorTest
    {
        [TestMethod]
        public void TestCompressor()
        {
            Util.Logger = new Logger();
            
            var testDir = new Uri(Path
                .Combine(new Uri(Assembly.GetExecutingAssembly().CodeBase)
                .AbsolutePath, @"..\..\..\..\..\tst"))
                .LocalPath;

            const string amlFileName = "aml.xml";

            var res = Directory.GetFiles(testDir).Where(f => !Path.GetFileName(f).Equals(amlFileName)).ToArray();
            var amlFile = Directory.GetFiles(testDir).First(f => Path.GetFileName(f).Equals(amlFileName));

            var finalAmlxFile = Path.Combine(testDir, "myAmlx.amlx");
            Compressor.Compress(amlFile, Path.Combine(testDir, "myAmlx.amlx"), res);

            using (var archive = ZipFile.OpenRead(finalAmlxFile))
            {
                foreach (var entry in archive.Entries)
                {
                    if (!entry.Name.Equals(amlFileName) && !res.Any(f => Path.GetFileName(f).Equals(entry.Name)))
                    {
                        try
                        {
                            File.Delete(finalAmlxFile);
                        }
                        catch
                        {
                            Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand!");
                        }
                        Assert.Fail($"We found {entry.Name}, which was not expected.");
                    }
                }
                foreach (var fileName in res.Select(Path.GetFileName))
                {
                    if (!archive.Entries.Any(f => f.Name.Equals(fileName)))
                    {
                        try
                        {
                            File.Delete(finalAmlxFile);
                        }
                        catch
                        {
                            Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand!");
                        }
                        Assert.Fail($"We are missing {fileName} in the ZIP-archive.");
                    }
                }
            }

            try
            {
                File.Delete(finalAmlxFile);
            }
            catch
            {
                Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand!");
            }
        }
    }
}
