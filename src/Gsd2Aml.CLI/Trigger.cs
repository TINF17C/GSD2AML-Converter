using Gsd2Aml.Lib;
using Gsd2Aml.Lib.Logging;
using System;
using System.IO;

namespace Gsd2Aml.Cli
{
    /// <summary>
    /// Acts on the settings and converts the input according to the settings.
    /// </summary>
    internal class Trigger
    {
        internal Settings Settings { get; }

        /// <summary>
        /// Constructor for Trigger.
        /// </summary>
        /// <param name="settings">The Settings object which contains all of the passed information.</param>
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

            Console.WriteLine($"{Environment.NewLine}Started conversion process.");
            Util.Logger.Log(LogLevel.Info, "The conversion process starts.");

            try
            {
                Converter.Logger = Util.Logger;
                if (Settings.StringOutput)
                {
                    var amlString = Converter.Convert(Settings.InputFile, Settings.Validation);
                    Console.WriteLine($"Successfully converted the GSD file to an AML string. {Environment.NewLine}");
                    Console.WriteLine(amlString);
                }
                else
                {
                    Converter.Convert(Settings.InputFile, Settings.OutputFile, true, Settings.Validation);
                    Console.WriteLine($"Successfully converted the GSD file to a .amlx package and saved it to {Settings.OutputFile}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Conversion failed. Please contact the developers. {e.Message}");
                Util.Logger.Log(LogLevel.Error, e.ToString());
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Checks if the output file already exists. If yes the user will be asked whether the file should be overwritten.
        /// </summary>
        private void CheckOutput()
        {
            var finfo = new FileInfo(Settings.OutputFile);
            if (!finfo.Exists) return;

            string userInput;

            Console.Write($"{Environment.NewLine}");

            do
            {
                Console.Write($"{finfo.FullName} already exists. Overwrite file? (y/n): ");
                userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.Write(Environment.NewLine);
            } while (!userInput.Equals("y") && !userInput.Equals("n"));

            if (!userInput.Equals("n")) return;

            Console.WriteLine($"{Environment.NewLine}Could not convert file because the output file should not be overwritten.");
            Util.Logger.Log(LogLevel.Info, "User does not want to overwrite the file.");
            Environment.Exit(0);
        }

        /// <summary>
        /// Checks if the output file is valid. If not it changes the string.
        /// </summary>
        /// <returns>A valid outputFile string.</returns>
        internal void GetOutputFile()
        {
            if (File.Exists(Settings.OutputFile)) return;

            var defaultFilePath = Lib.Util.GetOutputFileName(Settings.InputFile) + "x";

            if (string.IsNullOrEmpty(Settings.OutputFile))
            {
                Settings.OutputFile = defaultFilePath;
                return;
            }

            try
            {
                var directory = Path.GetDirectoryName(Settings.OutputFile);

                if (string.IsNullOrEmpty(directory)) {
                    Util.Logger.Log(LogLevel.Error, $"User passed invalid output path: {Settings.OutputFile}");
                    throw new NullReferenceException($"{Environment.NewLine}Error: You passed an invalid output path." +
                                                        $"{Environment.NewLine}For more information run 'gsd2aml --help'");
                }

                Directory.CreateDirectory(directory);
            }
            catch (Exception e)
            {
                Util.Logger.Log(LogLevel.Error, $"User passed invalid output path: {Settings.OutputFile}");
                throw new Exception($"{Environment.NewLine}Error: You passed an invalid output path." +
                                    $"{Environment.NewLine}For more information run 'gsd2aml --help'.", e);
            }

            if (string.IsNullOrEmpty(Path.GetExtension(Settings.OutputFile)) ||
                string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(Settings.OutputFile)))
            {
                Settings.OutputFile = Path.Combine(Settings.OutputFile, Path.GetFileName(defaultFilePath));
            }
        }
    }
}
