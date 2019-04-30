using Gsd2Aml.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.CLI
{

    public class Program
    {
        internal static Logger Log { get; } = new Logger();

        /// <summary>
        /// Starting point for the CLI Program. 
        /// </summary>
        /// <param name="args">Arguments which are passed to the program.</param>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Util.PrintHelpText();
            }

            try
            {
                var settings = new Settings(args);
                var trigger = new Trigger(settings);

                trigger.Convert();
            }
            catch (Exception e)
            {
                // TODO: change fatal
                Log.Log(LogLevel.Fatal, e.Message);
                Environment.Exit(1);
            }
            Environment.Exit(0);
        }
    }
}
