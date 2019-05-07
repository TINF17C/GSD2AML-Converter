using System;
using System.Collections.Generic;
using Gsd2Aml.Cli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gsd2Aml.Test
{
    [TestClass]
    public class CliTest
    {
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected ArgumentException.")]
        public void TestMultipleParameterErrorInvoke()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";

            var args = new List<string>() {"--input", inputPath, "--input", inputPath};
            var settings = new Settings() {Args = args};

            settings.PrintMultipleParameterError();
        }

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected ArgumentException.")]
        public void TestCheckCliArgumentsWithIllegalArguments()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "-i", inputPath};
            var settings = new Settings() { Args = args };

            settings.CheckCliArguments();
        }

        [TestMethod]
        public void TestCheckCliArgumentsWithLegalArguments()
        {
            const string inputPath = "C:\\Test\\input\\amlx.amlx";
            const string outputPath = "C:\\Test\\output\\amlx.amlx";

            var args = new List<string>() { "--input", inputPath, "--output", outputPath};
            var settings = new Settings() { Args = args };

            settings.CheckCliArguments();
        }

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
