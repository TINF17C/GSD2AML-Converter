using Gsd2Aml.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Cli
{
    public class Program
    {
        internal static Logger Log { get; } = new Logger();

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
        /// <param name="args">Arguments which are passed to the program.</param>
        private static void Main(string[] args)
        {
            var parameter = new Dictionary<string, string>
            {
                { CInputFile, string.Empty },
                { CInputFileShort, string.Empty },
                { COutputFile, string.Empty },
                { COutputFileShort, string.Empty }
            };

            if (args.Length == 0)
            {
                PrintHelpText();
            }
            CheckCliArguments(args);

            ParseCliArguments(args, parameter);

            var inputFile = string.IsNullOrEmpty(parameter[CInputFile]) ? parameter[CInputFileShort] : parameter[CInputFile];
            var outputFile = string.IsNullOrEmpty(parameter[COutputFile]) ? parameter[COutputFileShort] : parameter[COutputFile];
            var stringOutput = Array.IndexOf(args, CStringOutputShort) >= 0 || Array.IndexOf(args, CStringOutput) >= 0;

            if (File.Exists(inputFile))
            {
                CheckOutputAndRunConverter(inputFile, outputFile, stringOutput);
            }
            else if (File.Exists(args[0]))
            {
                CheckOutputAndRunConverter(args[0], outputFile, stringOutput);
            }
            else
            {
                Log.Log(LogLevel.Fatal, "Invalid input file. GSD-File does not exist.");
                Console.WriteLine($"{Environment.NewLine}Error: Input file not found. Please enter a valid path to a GSD-formatted file." +
                                  $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                Environment.Exit(1);
            }
            Environment.Exit(0);
        }

        /// <summary>
        /// This method checks three things:
        /// 1) If the user passed multiple times the same argument. E.g. gsd2aml -i -i
        /// 2) If the user passed multiple times the corresponding long/short argument to a argument. E.g. gsd2aml -i --input
        /// 3) If the user passed --output and --string at the same time.
        /// </summary>
        /// <param name="args">Arguments which are passed to the program.</param>
        private static void CheckCliArguments(IList<string> args)
        {
            for (var i = 0; i < Arguments.Length - 1; i++)
            {
                if (args.IndexOf(Arguments[i]) >= 0 && args.IndexOf(Arguments[i + 1]) >= 0)
                {
                    PrintLongShortParameterError(Arguments[i], Arguments[i + 1]);
                }
                i++;
            }

            if (args.Count != args.Distinct().Count())
            {
                PrintMultipleParameterError(args);
            }
            if ((args.IndexOf(COutputFile) >= 0 || args.IndexOf(COutputFileShort) >= 0) && (args.IndexOf(CStringOutput) >= 0 || args.IndexOf(CStringOutputShort) >= 0))
            {
                PrintLongShortParameterError(COutputFile, CStringOutput);
            }
        }

        /// <summary>
        /// This method parses the CLI Arguments and saves them to a dictionary.
        /// </summary>
        /// <param name="args">Arguments which are passed to the program.</param>
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
            outputFile = GetOutputFile(inputFile, outputFile);
            var finfo = new FileInfo(outputFile);

            // Directory check. If it does not exist, it tries to create the output directory.
            if (finfo.Directory != null && !string.IsNullOrEmpty(finfo.DirectoryName) && !finfo.Directory.Exists)
            {
                try
                {
                    Directory.CreateDirectory(finfo.DirectoryName);
                }
                catch (Exception e)
                {
                    Log.Log(LogLevel.Error, e.Message);
                    Log.Log(LogLevel.Trace, e.StackTrace);
                    Console.WriteLine($"{Environment.NewLine}Error: Could not create output directory.");
                    Environment.Exit(1);
                }
            }

            // File check. If the output file exists, it asks if the user wants to overwrite the file.
            if (finfo.Exists)
            {
                string userInput;

                do
                {
                    Console.Write($"{finfo.FullName} exists already. Overwrite file? (y/n): ");
                    userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                    Console.WriteLine(Environment.NewLine);
                } while (!userInput.Equals("y") && !userInput.Equals("n"));

                if (userInput.Equals("n"))
                {
                    Console.WriteLine("Could not convert file because the output file should not be overwritten.");
                    Environment.Exit(0);
                }
            }

            try
            {
                Converter.Convert(inputFile, outputFile, stringOutput);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                if (!string.IsNullOrEmpty(inputDirectoryName)) return Path.Combine(inputDirectoryName, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
            }
            if (string.IsNullOrEmpty(Path.GetExtension(outputFile)) || string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(outputFile)))
            {
                if (outputFile != null) return Path.Combine(outputFile, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
            }
            return outputFile;
        }

        /// <summary>
        /// Prints an error message if the same parameter is used mutliple times.
        /// </summary>
        /// <param name="args">Arguments which are passed to the program.</param>
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
                    Log.Log(LogLevel.Fatal, $"User used {argument} multiple times.");
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
            Log.Log(LogLevel.Fatal, $"User used {firstParameter} and {secondParameter} together while only one of them is allowed.");
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
