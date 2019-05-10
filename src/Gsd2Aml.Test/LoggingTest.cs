using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System;
using System.IO;

namespace Gsd2Aml.Test
{
    /// <summary>
    /// Tests the logger.
    /// </summary>
    [TestClass]
    public class LoggingTest
    {
        /// <summary>
        /// Checks whether various messages are logged correctly for the CLI.
        /// </summary>
        [TestMethod]
        public void TestCliLogging()
        {
            var logger = new Cli.Logger();
            const string logMessage1 = "Logging 1";
            const string logMessage2 = "Logging 2";
            const string logMessage3 = "Logging 3";
            const string logMessage4 = "Logging 4";
            const string logMessage5 = "Logging 5";
            const string logMessage6 = "Logging 6";
            const string logMessage7 = "Logging 7";

            var filename = GetLogFileName("cli_logfile");

            // should appear in log file
            logger.Log(Lib.Logging.LogLevel.Info, logMessage1);
            logger.Log(Lib.Logging.LogLevel.Warning, logMessage2);
            logger.Log(Lib.Logging.LogLevel.Error, logMessage3);
            logger.Log(Lib.Logging.LogLevel.Fatal, logMessage4);

            // should not be written in log file
            logger.Log(Lib.Logging.LogLevel.Off, logMessage5);
            logger.Log(Lib.Logging.LogLevel.Debug, logMessage6);
            logger.Log(Lib.Logging.LogLevel.Trace, logMessage7);
            LogManager.Flush();

            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GSD2AML", "Logs", "CLI", filename);
            if (File.Exists(filepath))
            {
                var logText = File.ReadAllText(filepath);
                if (!logText.Contains("INFO") || !logText.Contains(logMessage1))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage1}' with level 'Info'");
                }
                if (!logText.Contains("WARN") || !logText.Contains(logMessage2))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage2}' with level 'Warning'");
                }
                if (!logText.Contains("ERROR") || !logText.Contains(logMessage3))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage3}' with level 'Error'");
                }
                if (!logText.Contains("FATAL") || !logText.Contains(logMessage4))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage4}' with level 'Fatal'");
                }

                if (logText.Contains("OFF") || logText.Contains(logMessage5))
                {
                    throw new ArgumentException($"We found log message '{logMessage5}' with level 'Off', which was not expected");
                }
                if (logText.Contains("DEBUG") || logText.Contains(logMessage6))
                {
                    throw new ArgumentException($"We found log message '{logMessage6}' with level 'Debug', which was not expected");
                }
                if (logText.Contains("TRACE") || logText.Contains(logMessage7))
                {
                    throw new ArgumentException($"We found log message '{logMessage7}' with level 'Trace', which was not expected");
                }
            }
            else
            {
                throw new ArgumentException($"We are missing file {filepath}");
            }

        }

        /// <summary>
        /// Checks whether various messages are logged correctly for the GUI.
        /// </summary>
        [TestMethod]
        public void TestGuiLogging()
        {
            var logger = new Gui.Logger();
            const string logMessage1 = "Logging 1";
            const string logMessage2 = "Logging 2";
            const string logMessage3 = "Logging 3";
            const string logMessage4 = "Logging 4";
            const string logMessage5 = "Logging 5";
            const string logMessage6 = "Logging 6";
            const string logMessage7 = "Logging 7";

            var filename = GetLogFileName("gui_logfile");
            logger.Log(Lib.Logging.LogLevel.Info, logMessage1);
            logger.Log(Lib.Logging.LogLevel.Warning, logMessage2);
            logger.Log(Lib.Logging.LogLevel.Error, logMessage3);
            logger.Log(Lib.Logging.LogLevel.Fatal, logMessage4);

            // should not be logged
            logger.Log(Lib.Logging.LogLevel.Off, logMessage5);
            logger.Log(Lib.Logging.LogLevel.Debug, logMessage6);
            logger.Log(Lib.Logging.LogLevel.Trace, logMessage7);
            LogManager.Flush();

            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GSD2AML", "Logs", "GUI", filename);
            if (File.Exists(filepath))
            {
                var logText = File.ReadAllText(filepath);
                if (!logText.Contains("INFO") || !logText.Contains(logMessage1))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage1}' with level 'Info'");
                }
                if (!logText.Contains("WARN") || !logText.Contains(logMessage2))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage2}' with level 'Warning'");
                }
                if (!logText.Contains("ERROR") || !logText.Contains(logMessage3))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage3}' with level 'Error'");
                }
                if (!logText.Contains("FATAL") || !logText.Contains(logMessage4))
                {
                    throw new ArgumentException($"We are missing log message '{logMessage4}' with level 'Fatal'");
                }

                if (logText.Contains("OFF") || logText.Contains(logMessage5))
                {
                    throw new ArgumentException($"We found log message '{logMessage5}' with level 'Off', which was not expected");
                }
                if (logText.Contains("DEBUG") || logText.Contains(logMessage6))
                {
                    throw new ArgumentException($"We found log message '{logMessage6}' with level 'Debug', which was not expected");
                }
                if (logText.Contains("TRACE") || logText.Contains(logMessage7))
                {
                    throw new ArgumentException($"We found log message '{logMessage7}' with level 'Trace', which was not expected");
                }
            }
            else
            {
                throw new ArgumentException($"We are missing file {filepath}");
            }
        }

        /// <summary>
        /// Gets the file name of the current log file.
        /// </summary>
        /// <param name="searchedTarget">The log target name.</param>
        /// <returns>The file name of the log file.</returns>
        private static string GetLogFileName(string searchedTarget)
        {
            var wrapperTarget = LogManager.Configuration.FindTargetByName(searchedTarget) as WrapperTargetBase;
            var fileTarget = wrapperTarget?.WrappedTarget as FileTarget;

            var logEventInfo = new LogEventInfo { TimeStamp = DateTime.Now };
            var filePath = fileTarget?.FileName.Render(logEventInfo);
            return Path.GetFileName(filePath);
        }
    }
}
