using System;
using System.IO;
using Gsd2Aml.Lib;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Cli
{
    internal class Trigger
    {
        internal Settings Settings { get; }

        /// <summary>
        /// Constructor for Trigger.
        /// </summary>
        /// <param name="settings">The Settings object which contains all argument information.</param>
        internal Trigger(Settings settings)
        {
            Settings = settings;
            GetOutputFile();
        }

        /// <summary>
        /// This method checks the output directory and file. Then it runs the converter.
        /// </summary>
        internal void Convert()
        {
            if (!Settings.StringOutput)
            {
                Util.Logger.Log(LogLevel.Info, $"Set output path to: {Settings.OutputFile}");
                CheckOutput();
            }

            Util.Logger.Log(LogLevel.Info, "The conversion process starts.");
            Console.WriteLine("Started conversion process.");

            try
            {
                Lib.Util.Logger = Util.Logger;
                if (Settings.StringOutput)
                {
                    var amlString = Converter.Convert(Settings.InputFile);
                    Console.WriteLine($"Successfully converted the GSD file to an AML string. {Environment.NewLine}");
                    Console.WriteLine(amlString);
                }
                else
                {
                    Converter.Convert(Settings.InputFile, Settings.OutputFile, true);
                    Console.WriteLine($"Successfully converted the GSD file to a .amlx package and saved it to {Settings.OutputFile}");
                }
            }
            catch (Exception e)
            {
                Util.Logger.Log(LogLevel.Error, "Conversion failed." +
                                                $"{Environment.NewLine}{e}");
                Console.WriteLine($"Conversion failed. Please contact the developers. {e.Message}");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Checks if the output file already exists.
        /// Asks the user whether to overwrite the file or stop the conversion.
        /// </summary>
        private void CheckOutput()
        {
            var finfo = new FileInfo(Settings.OutputFile);
            if (!finfo.Exists) return;

            string userInput;

            do
            {
                Console.Write($"{finfo.FullName} exists already. Overwrite file? (y/n): ");
                userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.WriteLine(Environment.NewLine);
            } while (!userInput.Equals("y") && !userInput.Equals("n"));

            if (!userInput.Equals("n")) return;

            Util.Logger.Log(LogLevel.Info, "The user does not want to overwrite the file.");
            Console.WriteLine("Could not convert file because the output file should not be overwritten.");
            Environment.Exit(0);
        }

        /// <summary>
        /// Checks if the output file is valid. If not it changes the string:
        /// 1) outputFile is empty --> inputFileDirectory + timestamp.amlx
        /// 2) outputFile is like ...\test or ...\.amlx --> outputDirectory + timestamp.amlx (Example: ...\test\[timestamp].amlx ...\.amlx\[timestamp].amlx)
        /// </summary>
        /// <returns>A valid outputFile string.</returns>
        internal void GetOutputFile()
        {
            if (string.IsNullOrEmpty(Settings.OutputFile))
            {
                var inputDirectoryName = Path.GetDirectoryName(Settings.InputFile);
                if (!string.IsNullOrEmpty(inputDirectoryName))
                {
                    Settings.OutputFile = Path.Combine(inputDirectoryName, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
                }
            }

            if (!string.IsNullOrEmpty(Path.GetExtension(Settings.OutputFile)) &&
                !string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(Settings.OutputFile))) return;

            if (Settings.OutputFile != null)
            {
                Settings.OutputFile = Path.Combine(Settings.OutputFile, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
            }
        }
    }
}
