/*
 *  Copyright (C) 2019 GSD2AML Team (Nico Dietz, Steffen Gerdes, Constantin Ruhdorfer,
 *  Jonas Komarek, Phuc Quang Vu, Michael Weidmann)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published by
 *  the Free Software Foundation version 3 of the License.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Reflection;

namespace Gsd2Aml.Cli
{
    /// <summary>
    /// Contains utility logic.
    /// </summary>
    internal static class Util
    {
        internal static Logger Logger { get; } = new Logger();

        private static string HelpText { get; } = $"{Environment.NewLine}{System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductName} " +
                                                  $"(Version: {System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion})" +
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
                                                  $"{Environment.NewLine}\t\t\t\tIf nothing is specified default is: C:\\path\\to\\input\\file\\<input-file-name>.amlx (OPTIONAL)" +
                                                  $"{Environment.NewLine}\t-s, --string\t\tPrints the generated AML XML file to stdout. No *.amlx file will be generated. (OPTIONAL)" +
                                                  $"{Environment.NewLine}\t-n, --novalidate\tValidates the GSD not against the specification. (OPTIONAL)" +
                                                  $"{Environment.NewLine}Note:" +
                                                  $"{Environment.NewLine}\t--output and --string cannot be used together." +
                                                  $"{Environment.NewLine}" +
                                                  $"{Environment.NewLine}Find us on GitHub: https://github.com/TINF17C/GSD2AML-Converter";

        /// <summary>
        /// Prints the help text and exits the program.
        /// </summary>
        internal static void PrintHelpText()
        {
            Console.WriteLine(HelpText);
            Environment.Exit(0);
        }
    }
}
