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

using Gsd2Aml.Lib.Logging;
using System;
using System.Linq;

namespace Gsd2Aml.Cli
{
    public static class Program
    {
        /// <summary>
        /// Starting point for the CLI Program. 
        /// </summary>
        /// <param name="args">Arguments which were passed to the program.</param>
        private static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            if (args.Length == 0 || args.Contains(Settings.CHelp) || args.Contains(Settings.CHelpShort))
            {
                Util.Logger.Log(LogLevel.Info, "Arguments array is empty or contains a -h/--help flag.");
                Util.PrintHelpText();
            }

            try
            {
                var settings = new Settings(args.ToList());
                var trigger = new Trigger(settings);

                trigger.Convert();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Util.Logger.Log(LogLevel.Error, e.ToString());
                Environment.Exit(1);
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
            Environment.Exit(0);
        }
    }
}
