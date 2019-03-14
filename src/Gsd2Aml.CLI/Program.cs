using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gsd2Aml.CLI
{
    public class Program
    {
        private const string CHelp = "--help";
        private const string CHelpShort = "-h";

        private const string CInputFile = "--input";
        private const string CInputFileShort = "-i";

        private const string COutputFile = "--output";
        private const string COutputFileShort = "-o";

        private const string CStringOutput = "--string";
        private const string CStringOutputShort = "-s";

        private static readonly string[] Arguments = { CHelp, CHelpShort, CInputFile, CInputFileShort, COutputFile, COutputFileShort, CStringOutput, CStringOutputShort };
        private static readonly string HelpText = $"{Environment.NewLine}GSD2AML Converter" +
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
                Console.WriteLine($"{Environment.NewLine}Input file not found. Please enter a valid path to a GSD-formatted file.{Environment.NewLine}For more information run 'gsd2aml --help'.");
                Environment.Exit(1);
            }
        }

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

        private static void CheckOutputAndRunConverter(string inputFile, string outputFile, bool stringOutput)
        {
            // Determine if outputFile is valid. If not a default with the timestamp as the name will be generated.
            if (string.IsNullOrEmpty(outputFile))
            {
                outputFile = Path.Combine(Path.GetDirectoryName(inputFile), DateTime.Now + ".amlx");
            }

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
                    Console.WriteLine($"{Environment.NewLine}Could not create output directory.");
                    Environment.Exit(1);
                }
            }

            // File check. If the output file exists, it asks if the user wants to overwrite the file.
            if (!finfo.Exists) return;

            string userInput;

            do
            {
                Console.Write($"{finfo.FullName} exists already. Overwrite file? (y/n): ");
                userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.WriteLine(Environment.NewLine);
            } while (!userInput.Equals("y") && !userInput.Equals("n"));

            if (userInput.Equals("y"))
            {
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }

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
                    Console.WriteLine($"{Environment.NewLine}Error: You used {argument} multiple times." +
                                      $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                    Environment.Exit(1);
                }
            }
        }

        private static void PrintLongShortParameterError(string firstParameter, string secondParameter)
        {
            Console.WriteLine($"{Environment.NewLine}Error: You used {firstParameter} and {secondParameter} while only one of them is allowed." +
                              $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
            Environment.Exit(1);
        }

        private static void PrintHelpText()
        {
            Console.WriteLine(HelpText);
            Environment.Exit(0);
        }
    }
}
