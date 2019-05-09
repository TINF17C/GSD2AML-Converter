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
