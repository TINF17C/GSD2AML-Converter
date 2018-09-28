using System;
using System.Collections.Generic;
using System.IO;

namespace Gsd2Aml.CLI
{
    public class Program
    {
        private const string CPathToFile = "--path";
        private const string CPathToFileShort = "-p";

        private const string CStringOutput = "--string";
        private const string CStringOutputShort = "-s";

        private const string CHelp = "--help";
        private const string CHelpShort = "-h";
        private static readonly string HelpText = $"{Environment.NewLine}GSD2AML Converter{Environment.NewLine}{Environment.NewLine}Converts a GSD-formatted file in a AML-formatted file.{Environment.NewLine}{Environment.NewLine}Usage:{Environment.NewLine}\tgsd2aml [-p | --path] <path-to-gsd-file> [options]{Environment.NewLine}{Environment.NewLine}Options:{Environment.NewLine}\t-p, --path file\tThe path to the file which should be converted. (REQUIRED){Environment.NewLine}\t-s, --string\tSet the output type to a string. Default: the output type is a file. (OPTIONAL){Environment.NewLine}";

        private static void Main(string[] args)
        {
            var parameter = new Dictionary<string, string>
            {
                { CPathToFile, string.Empty },
                { CPathToFileShort, string.Empty }
            };

            if (args.Length == 0)
            {
                PrintHelpText();
            }

            CheckCliArguments(args);

            ParseCliArguments(args, parameter);

            var pathToFile = string.IsNullOrEmpty(parameter[CPathToFileShort]) ? parameter[CPathToFile] : parameter[CPathToFileShort];
            var stringOutput = Array.IndexOf(args, CStringOutputShort) >= 0 || Array.IndexOf(args, CStringOutput) >= 0;

            if (!string.IsNullOrEmpty(pathToFile) && File.Exists(pathToFile))
            {
                // TODO: call converter
                // convert(pathToFile, stringOutput);
            }
            else if (File.Exists(args[0]))
            {
                // TODO: call converter
                // convert(args[0], stringOutput);
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}File not found. Please enter a valid path to a GSD-formatted file.{Environment.NewLine}For more information: 'gsd2aml --help'.");
                Environment.Exit(1);
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
                else if (i + 1 < args.Count)
                {
                    if (parameter.ContainsKey(args[i]))
                    {
                        parameter[args[i]] = args[i + 1];
                    }
                }
            }
        }

        private static void CheckCliArguments(IList<string> args)
        {
            if (args.IndexOf(CPathToFileShort) >= 0 && args.IndexOf(CPathToFile) >= 0)
            {
                Console.WriteLine($"{Environment.NewLine}Error: You used {CPathToFile} and {CPathToFileShort} while only one of them is allowed.{Environment.NewLine}For more information: 'gsd2aml --help'.");
                Environment.Exit(1);
            }
            else if (args.IndexOf(CStringOutputShort) >= 0 && args.IndexOf(CStringOutput) >= 0)
            {
                Console.WriteLine($"{Environment.NewLine}Error: You used {CStringOutput} and {CStringOutputShort} while only one of them is allowed.{Environment.NewLine}For more information: 'gsd2aml --help'.");
                Environment.Exit(1);
            }
        }

        private static void PrintHelpText()
        {
            Console.WriteLine(HelpText);
            Environment.Exit(0);
        }
    }
}
