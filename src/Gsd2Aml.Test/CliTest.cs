using Gsd2Aml.Cli;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Gsd2Aml.Test
{
    /// <summary>
    /// Performs tests on the CLI.
    /// </summary>
    [TestClass]
    public class CliTest
    {
        /// <summary>
        /// Test whether the output file path is correctly set.
        /// </summary>
        [TestMethod]
        public void TestGetOutputFile()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var settings = new Settings {InputFile = inputPath, OutputFile = outputPath};
            var trigger = new Trigger(settings);

            var res = trigger.Settings.OutputFile;
            if (!res.EndsWith(".amlx"))
            {
                Assert.Fail("Output does not end with the extension '.amlx");
            }

            Assert.AreEqual(res, outputPath);
        }

        /// <summary>
        /// Checks whether .amlx is appended correctly to the output file.
        /// </summary>
        [TestMethod]
        public void TestGetOutputFileWithNoOutput()
        {
            const string input = "C:\\Test\\amlx.amlx";
            const string expected = "C:\\Test\\";

            var settings = new Settings { InputFile = input };
            var trigger = new Trigger(settings);

            var res = trigger.Settings.OutputFile;

            if (!res.EndsWith(".amlx"))
            {
                Assert.Fail("Output does not end with the extension '.amlx");
            }

            StringAssert.StartsWith(res, expected);
        }

        /// <summary>
        /// Checks whether the CLI fails on multiple, but equal parameters.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected ArgumentException.")]
        public void TestMultipleParameterErrorInvoke()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";

            var args = new List<string>() {"--input", inputPath, "--input", inputPath};
            var settings = new Settings() {Args = args};

            settings.PrintMultipleParameterError();
        }

        /// <summary>
        /// Checks whether multiple parameters are correctly parsed.
        /// </summary>
        [TestMethod]
        public void TestMultipleParameterErrorNoInvoke()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "--output", outputPath };
            var settings = new Settings() { Args = args };

            try
            {
                settings.PrintMultipleParameterError();
            }
            catch
            {
                Assert.Fail("Unexpected exception was thrown.");
            }
        }

        /// <summary>
        /// Tests whether the CLI fails on double short/long parameters. 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected ArgumentException.")]
        public void TestCheckCliArgumentsWithIllegalArguments()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "-i", inputPath};
            var settings = new Settings() { Args = args };

            settings.CheckCliArguments();
        }

        /// <summary>
        /// Tests whether the CLI works with legal arguments.
        /// </summary>
        [TestMethod]
        public void TestCheckCliArgumentsWithLegalArguments()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "--output", outputPath};
            var settings = new Settings() { Args = args };

            settings.CheckCliArguments();
        }

        /// <summary>
        /// Tests whether CLI arguments are parsed correctly.
        /// </summary>
        [TestMethod]
        public void TestParseCliArguments()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "--output", outputPath };
            var settings = new Settings() { Args = args };

            settings.ParseCliArguments();

            Assert.AreEqual(outputPath, settings.OutputFile);
            Assert.AreEqual(inputPath, settings.InputFile);

            args = new List<string>() {"--input", inputPath, "--string"};
            settings = new Settings() {Args = args};

            settings.ParseCliArguments();

            Assert.AreEqual(inputPath, settings.InputFile);
            Assert.AreEqual(true, settings.StringOutput);
        }
    }
}
