using Gsd2Aml.Lib;
using Gsd2Aml.Lib.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gsd2Aml.CLI
{
    public static class Program
    {
        private static Logger Logger { get; } = new Logger();

        private const string CHelp = "--help";
        private const string CHelpShort = "-h";

        private const string CInputFile = "--input";
        private const string CInputFileShort = "-i";

        private const string COutputFile = "--output";
        private const string COutputFileShort = "-o";

        private const string CStringOutput = "--string";
        private const string CStringOutputShort = "-s";

        private static string[] Arguments { get; } = { CHelp, CHelpShort, CInputFile, CInputFileShort, COutputFile, COutputFileShort, CStringOutput, CStringOutputShort };

        private static string HelpText { get; } = $"{Environment.NewLine}GSD2AML Converter" +
                                                  $"{Environment.NewLine}" +
                                                  $"{Environment.NewLine}Converts a GSD-formatted file in an AML-formatted file." +
                                                  $"{Environment.NewLine}" +
                                                  $"{Environment.NewLine}Usage:" +
                                                  $"{Environment.NewLine}\tgsd2aml [-i | --input] <path-to-gsd-file> [options]" +
                                                  $"{Environment.NewLine}" +
                                                  $"{Environment.NewLine}Options:" +
                                                  $"{Environment.NewLine}\t-h, --help\t\tPrints this info and the converter's usage/options." +
                                                  $"{Environment.NewLine}\t-i, --input file\tThe path to the file which should be converted. Example: C:\\path\\to\\input\\file.xml" +
                                                  $"{Environment.NewLine}\t-o, --output file\tSets the path to the output file. Example: C:\\path\\to\\output\\file.amlx" +
                                                  $"{Environment.NewLine}\t\t\t\tIf nothing is specified default is: C:\\path\\to\\input\\file\\<timestamp>.amlx (OPTIONAL)" +
                                                  $"{Environment.NewLine}\t-s, --string\t\tPrints the generated AML XML file to stdout. No *.amlx file will be generated. (OPTIONAL)" +
                                                  $"{Environment.NewLine}Note:" +
                                                  $"{Environment.NewLine}\t--output and --string cannot be used together.";

        /// <summary>
        /// Starting point for the CLI Program. 
        /// </summary>
        /// <param name="args">Arguments which were passed to the program.</param>
        private static void Main(string[] args)
        {
            var parameter = new Dictionary<string, string>
            {
                { CInputFile, string.Empty },
                { CInputFileShort, string.Empty },
                { COutputFile, string.Empty },
                { COutputFileShort, string.Empty }
            };

            if (args.Length == 0 || args.Contains("-h") || args.Contains("--help"))
            {
                Logger.Log(LogLevel.Info, "Arguments array is empty or contains a -h/--help flag.");
                PrintHelpText();
            }
            CheckCliArguments(args);

            ParseCliArguments(args, parameter);

            var inputFile = string.IsNullOrEmpty(parameter[CInputFile]) ? parameter[CInputFileShort] : parameter[CInputFile];
            var outputFile = string.IsNullOrEmpty(parameter[COutputFile]) ? parameter[COutputFileShort] : parameter[COutputFile];
            var stringOutput = Array.IndexOf(args, CStringOutputShort) >= 0 || Array.IndexOf(args, CStringOutput) >= 0;

            if (File.Exists(inputFile))
            {
                Logger.Log(LogLevel.Info, $"Input file exists: {inputFile}");
                CheckOutputAndRunConverter(inputFile, outputFile, stringOutput);
            }
            else if (File.Exists(args[0]))
            {
                Logger.Log(LogLevel.Info, $"Input file exists: {args[0]}");
                CheckOutputAndRunConverter(args[0], outputFile, stringOutput);
            }
            else
            {
                Logger.Log(LogLevel.Error, "Input file does not exist.");
                Console.WriteLine($"{Environment.NewLine}Error: Input file not found. Please enter a valid path to a GSD-formatted file." +
                                  $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                Environment.Exit(1);
            }
            Environment.Exit(0);
        }

        /// <summary>
        /// This method checks three things:
        /// 1) If the user passed multiple times the same argument. E.g. gsd2aml -i -i
        /// 2) If the user passed multiple times the corresponding long/short argument to an argument. E.g. gsd2aml -i --input
        /// 3) If the user passed --output and --string at the same time.
        /// </summary>
        /// <param name="args">Arguments which were passed to the program.</param>
        private static void CheckCliArguments(IList<string> args)
        {
            for (var i = 0; i < Arguments.Length - 1; i += 2)
            {
                if (args.IndexOf(Arguments[i]) < 0 || args.IndexOf(Arguments[i + 1]) < 0) continue;

                Logger.Log(LogLevel.Error, $"User passed {Arguments[i]} and {Arguments[i + 1]} but only of them is allowed.");
                PrintLongShortParameterError(Arguments[i], Arguments[i + 1]);
            }

            if (args.Count != args.Distinct().Count())
            {
                PrintMultipleParameterError(args);
            }

            if (args.IndexOf(COutputFile) < 0 && args.IndexOf(COutputFileShort) < 0 || args.IndexOf(CStringOutput) < 0 && args.IndexOf(CStringOutputShort) < 0) return;

            Logger.Log(LogLevel.Error, "User passed -o/--output and -s/--string at the same time.");
            PrintLongShortParameterError(COutputFile, CStringOutput);
        }

        /// <summary>
        /// This method parses the CLI Arguments and saves them to a dictionary.
        /// </summary>
        /// <param name="args">Arguments which were passed to the program.</param>
        /// <param name="parameter">The dictionary which will contain the arguments and the corresponding data.</param>
        private static void ParseCliArguments(IList<string> args, IDictionary<string, string> parameter)
        {
            for (var i = 0; i < args.Count; i++)
            {
                if (args[i].Equals(CHelp) || args[i].Equals(CHelpShort))
                {
                    PrintHelpText();
                }
                else if (parameter.ContainsKey(args[i]))
                {
                    if (i + 1 < args.Count)
                    {
                        parameter[args[i]] = args[i + 1];
                    }
                }
            }
        }

        /// <summary>
        /// This method checks the output directory and file. Then it runs the converter.
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <param name="stringOutput">A boolean whether a file output or a string output is needed.</param>
        private static void CheckOutputAndRunConverter(string inputFile, string outputFile, bool stringOutput)
        {
            if (!stringOutput)
            {
                outputFile = GetOutputFile(inputFile, outputFile);
                Logger.Log(LogLevel.Info, $"Set output path to: {outputFile}");
                var finfo = new FileInfo(outputFile);

                // TODO: Remove the directory check, if the compressor already creates the output path.
                // Directory check. If it does not exist, it tries to create the output directory.
                if (finfo.Directory != null && !string.IsNullOrEmpty(finfo.DirectoryName) && !finfo.Directory.Exists)
                {
                    try
                    {
                        Directory.CreateDirectory(finfo.DirectoryName);
                    }
                    catch (Exception e)
                    {
                        Logger.Log(LogLevel.Error, "Could not create the output directory." +
                                                   $"{Environment.NewLine}{e}");
                        Console.WriteLine($"{Environment.NewLine}Error: Could not create output directory." +
                                          $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                        Environment.Exit(1);
                    }
                }

                // File check. If the output file exists, it asks if the user wants to overwrite the file.
                if (finfo.Exists)
                {
                    Logger.Log(LogLevel.Info, "The output file exists already. The user has to decide whether the file should be overwritten.");
                    string userInput;

                    do
                    {
                        Console.Write($"{finfo.FullName} exists already. Overwrite file? (y/n): ");
                        userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                        Console.WriteLine(Environment.NewLine);
                    } while (!userInput.Equals("y") && !userInput.Equals("n"));

                    if (userInput.Equals("n"))
                    {
                        Logger.Log(LogLevel.Info, "The user does not want to overwrite the file.");
                        Console.WriteLine("Could not convert file because the output file should not be overwritten.");
                        Environment.Exit(0);
                    }
                    Logger.Log(LogLevel.Info, "The user accepted an overwrite of the file.");
                }
            }

            try
            {
                Util.Logger = Logger;
                Logger.Log(LogLevel.Info, "The conversion process starts.");
                Console.WriteLine("Started conversion process.");

                if (stringOutput)
                {
                    var amlString = Converter.Convert(inputFile);
                    Console.WriteLine($"Successfully converted the GSD file to an AML string. {Environment.NewLine}");
                    Console.WriteLine(amlString);
                }
                else
                {
                    Converter.Convert(inputFile, outputFile, true);
                    Console.WriteLine($"Successfully converted the GSD file to a .amlx package and saved it to {outputFile}");
                }
            }
            catch (Exception e)
            {
                Logger.Log(LogLevel.Error, "Conversion failed." +
                                           $"{Environment.NewLine}{e}");
                Console.WriteLine($"Conversion failed. Please contact the developers. {e.Message}");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Checks if the output file is valid. If not it changes the string:
        /// 1) outputFile is empty --> inputFileDirectory + timestamp.amlx
        /// 2) outputFile is like ...\test or ...\.amlx --> outputDirectory + timestamp.amlx (Example: ...\test\[timestamp].amlx ...\.amlx\[timestamp].amlx)
        /// </summary>
        /// <param name="inputFile">The path to the input file.</param>
        /// <param name="outputFile">The path to the output file.</param>
        /// <returns>A valid outputFile string.</returns>
        private static string GetOutputFile(string inputFile, string outputFile)
        {
            if (string.IsNullOrEmpty(outputFile))
            {
                var inputDirectoryName = Path.GetDirectoryName(inputFile);
                if (!string.IsNullOrEmpty(inputDirectoryName))
                {
                    return Path.Combine(inputDirectoryName, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
                }
            }

            if (!string.IsNullOrEmpty(Path.GetExtension(outputFile)) && !string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(outputFile)))
            {
                return outputFile;
            }   

            return outputFile != null ? Path.Combine(outputFile, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx") : null;
        }

        /// <summary>
        /// Prints an error message if the same parameter was used mutliple times.
        /// </summary>
        /// <param name="args">Arguments which were passed to the program.</param>
        private static void PrintMultipleParameterError(IEnumerable<string> args)
        {
            var iteratedArguments = new HashSet<string>();

            foreach (var argument in args)
            {
                if (!Arguments.Contains(argument)) continue;
                if (!iteratedArguments.Contains(argument))
                {
                    iteratedArguments.Add(argument);
                }
                else
                {
                    Logger.Log(LogLevel.Error, $"User passed {argument} multiple times.");
                    Console.WriteLine($"{Environment.NewLine}Error: You used {argument} multiple times." +
                                      $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                    Environment.Exit(1);
                }
            }
        }

        /// <summary>
        /// Prints an error message if an argument is used with the corresponding long/short parameter.
        /// </summary>
        /// <param name="firstParameter">The first parameter of the long/short argument pair.</param>
        /// <param name="secondParameter">The second parameter of the long/short argument pair.</param>
        private static void PrintLongShortParameterError(string firstParameter, string secondParameter)
        {
            Console.WriteLine($"{Environment.NewLine}Error: You used {firstParameter} and {secondParameter} while only one of them is allowed." +
                              $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
            Environment.Exit(1);
        }

        /// <summary>
        /// Prints the help text and exits the program.
        /// </summary>
        private static void PrintHelpText()
        {
            Console.WriteLine(HelpText);
            Environment.Exit(0);
        }
    }
}
