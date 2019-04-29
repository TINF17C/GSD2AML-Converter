using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gsd2Aml.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gsd2Aml.Test
{
    [TestClass]
    public class CliTest
    {
        [TestMethod]
        public void TestGetOutputFile()
        {
            Util.Logger = new Logger();

            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var res = CLI.Program.GetOutputFile(inputPath, outputPath);

            if (!res.EndsWith(".amlx"))
            {
                Assert.Fail("Output does not end with the extension '.amlx");
            }

            Assert.AreEqual(res, outputPath);
        }

        [TestMethod]
        public void TestGetOutputFileWithNoOutput()
        {
            Util.Logger = new CLI.Logger();

            const string input = "C:\\Test\\amlx.amlx";
            const string expected = "C:\\Test\\";

            var res = CLI.Program.GetOutputFile(input, null);

            if (!res.EndsWith(".amlx"))
            {
                Assert.Fail("Output does not end with the extension '.amlx");
            }

            StringAssert.StartsWith(res, expected);
        }

    }
}
