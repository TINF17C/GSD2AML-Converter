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
            var failed = false;
            string errorMsg = null;

            Util.Logger = new Logger();

            var testDir = new Uri(Path
                .Combine(new Uri(Assembly.GetExecutingAssembly().CodeBase)
                .LocalPath, @"..\..\..\..\..\tst"))
                .LocalPath;

            const string amlFileName = "aml.xml";

            var res = Directory.GetFiles(testDir).Where(f => !Path.GetFileName(f).Equals(amlFileName)).ToArray();
            var amlFile = Directory.GetFiles(testDir).First(f => Path.GetFileName(f).Equals(amlFileName));

            var finalAmlxFile = Path.Combine(testDir, "myAmlx.amlx");
            Compressor.Compress(amlFile, Path.Combine(testDir, "myAmlx.amlx"), res, true);

            using (var archive = ZipFile.OpenRead(finalAmlxFile))
            {               
                foreach (var fileName in res.Select(Path.GetFileName))
                {
                    if (archive.Entries.Any(f => f.Name.Equals(fileName))) continue;
                    failed = true;
                    errorMsg = $"We are missing {fileName} in the ZIP-archive.";
                }
            }
            try
            {
                File.Delete(finalAmlxFile);
            }
            catch
            {
                Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand under ./tst/ .");
            }
            if (failed) Assert.Fail(errorMsg);
        }

        [TestMethod]
        public void FailOnOmittedAmlName() 
        {
            var exceptionOccured = false;
            try
            {
                Compressor.Compress("", "randomDestination", null);
            }
            catch
            {
                exceptionOccured = true;
            }
            if (!exceptionOccured)
            {
                Assert.Fail("Compress function should thrown an exception on empty AML name.");
            }

        }

        [TestMethod]
        public void FailOnOmittedDestinationPath()
        {
            var exceptionOccured = false;
            try
            {
                Compressor.Compress("myAml.xml", "", null);
            }
            catch
            {
                exceptionOccured = true;
            }
            if (!exceptionOccured)
            {
                Assert.Fail("Compress function should thrown an exception on empty destination string.");
            }
        }

        [TestMethod]
        public void TestEmptyResources()
        {
            var exceptionOccured = false;

            var testDir = new Uri(Path
                .Combine(new Uri(Assembly.GetExecutingAssembly().CodeBase)
                .LocalPath, @"..\..\..\..\..\tst"))
                .LocalPath;

            const string amlFileName = "aml.xml";

            var res = new string[0];
            var amlFile = Directory.GetFiles(testDir).First(f => Path.GetFileName(f).Equals(amlFileName));

            var finalAmlxFile = Path.Combine(testDir, "myAmlx.amlx");
            try
            {
                Compressor.Compress(amlFile, Path.Combine(testDir, "myAmlx.amlx"), res, true);
                try
                {
                    File.Delete(finalAmlxFile);
                }
                catch
                {
                    Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand under ./tst/ .");
                }
            }
            catch
            {
                exceptionOccured = true;
            }
            try
            {
                File.Delete(finalAmlxFile);
            }
            catch
            {
                Assert.Fail("Failed to delete the test AMLX File. You might need to delete it by hand under ./tst/ .");
            }

            if (!exceptionOccured) return;
            Assert.Fail("Compress function should work without resources.");
        }
    }
}
