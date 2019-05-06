using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gsd2Aml.Cli
{
    internal class Settings
    {
        public string InputFile { get; set; }
        public string OutputFile { get; set; }
        public bool AsString { get; set; }
        public IList<string> Args { get; set; }

        private const string CHelp = "--help";
        private const string CHelpShort = "-h";

        private const string CInputFile = "--input";
        private const string CInputFileShort = "-i";

        private const string COutputFile = "--output";
        private const string COutputFileShort = "-o";

        private const string CStringOutput = "--string";
        private const string CStringOutputShort = "-s";
        private static string[] Arguments { get; } = { CHelp, CHelpShort, CInputFile, CInputFileShort, COutputFile, COutputFileShort, CStringOutput, CStringOutputShort };

        /// <summary>
        /// Empty constructor for testing purposes.
        /// </summary>
        internal Settings() { }

        /// <summary>
        /// Constructor for Settings.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public Settings(IList<string> args)
        {
            Args = args;
            CheckCliArguments();
            ParseCliArguments();
            CheckGsdmlExistence();
        }

        /// <summary>
        /// This method checks three things:
        /// 1. Does the user use the long and the short version of a flag?
        /// 2. Does the user use a flag multiple times?
        /// 3. Does the user use the -o (--output) and the -s (--string) flag at the same time?
        /// If one of the above happen, an error is thrown.
        /// </summary>
        /// <exception cref="ArgumentException">The argument list is invalid.</exception>
        internal void CheckCliArguments()
        {
            for (var i = 0; i < Arguments.Length - 1; i+=2)
            {
                if (Args.IndexOf(Arguments[i]) >= 0 && Args.IndexOf(Arguments[i + 1]) >= 0)
                {
                    Console.WriteLine($"{Environment.NewLine}Error: You used {Arguments[i]} and {Arguments[i + 1]} while only one of them is allowed." +
                                      $"{Environment.NewLine}For more information run 'gsd2aml --help'.");
                    throw new ArgumentException($"User used {Arguments[i]} and {Arguments[i + 1]} together while only one of them is allowed.");
                }
            }

            if (Args.Count != Args.Distinct().Count())
            {
                PrintMultipleParameterError();
            }

            if ((Args.IndexOf(COutputFile) >= 0 || Args.IndexOf(COutputFileShort) >= 0) && (Args.IndexOf(CStringOutput) >= 0 || Args.IndexOf(CStringOutputShort) >= 0))
            {
                throw new ArgumentException($"User used {COutputFile} and {CStringOutput} together while only one of them is allowed.");
            }

        }

        /// <summary>
        /// Prints an error message if the same argument is used multiple times.
        /// </summary>
        /// <exception cref="ArgumentException">An argument was used multiple times.</exception>
        internal void PrintMultipleParameterError()
        {
            var iteratedArguments = new HashSet<string>();

            foreach (var argument in Args)
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

                    throw new ArgumentException($"User used {argument} multiple times.");
                }
            }
        }

        /// <summary>
        /// This method parses the CLI Arguments and maps them to the Settings properties.
        /// </summary>
        internal void ParseCliArguments()
        {
            var parameter = new Dictionary<string, string>
            {
                { CInputFile, null },
                { CInputFileShort, null },
                { COutputFile, null },
                { COutputFileShort, null}
            };

            for (var i = 0; i < Args.Count; i++)
            {
                if (Args[i].Equals(CHelp) || Args[i].Equals(CHelpShort))
                {
                    Util.PrintHelpText();
                }

                if (parameter.ContainsKey(Args[i]))
                {
                    if (i + 1 < Args.Count)
                    {
                        parameter[Args[i]] = Args[i + 1];
                    }
                }
            }

            InputFile = parameter[CInputFile] ?? parameter[CInputFileShort];
            OutputFile = parameter[COutputFile] ?? parameter[COutputFileShort];

            AsString = Array.IndexOf(Args.ToArray(), CStringOutputShort) >= 0 || Array.IndexOf(Args.ToArray(), CStringOutput) >= 0;
        }

        /// <summary>
        /// Checks for the GDSML existence.
        /// </summary>
        /// <exception cref="FileNotFoundException">The GSDML file could not be found.</exception>
        private void CheckGsdmlExistence()
        {
            if (File.Exists(InputFile)) return;
            if (File.Exists(Args[0]))
            {
                InputFile = Args[0];
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Error: Input file not found. Please enter a valid path to a GSD-formatted file." +
                                  $"{Environment.NewLine}For more information run 'gsd2aml --help'.");

                throw new FileNotFoundException("Invalid input file. GSD-File does not exist.");
            }
        }
    }
}
