/*
 *  Copyright (C) 2019 GSD2AML Team (Nico Dietz, Steffen Gerdes, Constantin Ruhdorfer,
 *  Jonas Komarek, Phuc Quang Vu, Michael Weidmann)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published by
 *  the Free Software Foundation version 3 of the License.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Gsd2Aml.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace Gsd2Aml.Test
{
    /// <summary>
    /// Tests the compressor.
    /// </summary>
    [TestClass]
    public class CompressorTest
    {
        /// <summary>
        /// A full end-to-end test of the compressor.
        /// Checks for:
        ///     1. A correctly stored .amlx package
        ///     2. The correct content within the .amlx package
        /// Deletes the package at the end.
        /// </summary>
        [TestMethod]
        public void TestCompressor()
        {
            var failed = false;
            string errorMsg = null;

            Converter.Logger = new Logger();

            var testDir = new Uri(Path
                .Combine(new Uri(Assembly.GetExecutingAssembly().CodeBase)
                .LocalPath, @"..\..\..\..\..\tst"))
                .LocalPath;

            const string amlFileName = "aml.xml";

            var res = Directory.GetFiles(testDir).Where(f => !Path.GetFileName(f).Equals(amlFileName)).ToArray();
            var amlFile = Directory.GetFiles(testDir).First(f => Path.GetFileName(f).Equals(amlFileName));

            // Tests for 1)

            var finalAmlxFile = Path.Combine(testDir, "myAmlx.amlx");
            Compressor.Compress(amlFile, Path.Combine(testDir, "myAmlx.amlx"), res, true);

            using (var archive = ZipFile.OpenRead(finalAmlxFile))
            {
                // Tests for 2)
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

        /// <summary>
        /// Checks whether the Compressor fails on omitted AML name.
        /// </summary>
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

        /// <summary>
        /// Checks whether the Compressor fails on omitted destination path.
        /// </summary>
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

        /// <summary>
        /// Tests whether the Compressor works correctly when no resources are specified.
        /// </summary>
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
