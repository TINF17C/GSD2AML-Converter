using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Gsd2Aml.Test
{
    [TestClass]
    public class LoggingTest
    {
        [TestMethod]
        public void TestCliLogging()
        {
            var logger = new CLI.Logger();
            const string logMessage1 = "Logging 1";
            const string logMessage2 = "Logging 2";
            const string logMessage3 = "Logging 3";
            const string logMessage4 = "Logging 4";
            const string logMessage5 = "Logging 5";
            const string logMessage6 = "Logging 6";
            const string logMessage7 = "Logging 7";

            var filename = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".log";
            // should appear in log file
            logger.Log(Lib.Logging.LogLevel.Info, logMessage1);
            logger.Log(Lib.Logging.LogLevel.Warning, logMessage2);
            logger.Log(Lib.Logging.LogLevel.Error, logMessage3);
            logger.Log(Lib.Logging.LogLevel.Fatal, logMessage4);


            //should not be written in log file
            logger.Log(Lib.Logging.LogLevel.Off, logMessage5);
            logger.Log(Lib.Logging.LogLevel.Debug, logMessage6);
            logger.Log(Lib.Logging.LogLevel.Trace, logMessage7);

            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GSD2AML", "Logs", filename);
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
                throw new ArgumentException($"We are missing file {filename}");
            }

        }

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

            var filename = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".log";
            logger.Log(Lib.Logging.LogLevel.Info, logMessage1);
            logger.Log(Lib.Logging.LogLevel.Warning, logMessage2);
            logger.Log(Lib.Logging.LogLevel.Error, logMessage3);
            logger.Log(Lib.Logging.LogLevel.Fatal, logMessage4);


            //should not be logged
            logger.Log(Lib.Logging.LogLevel.Off, logMessage5);
            logger.Log(Lib.Logging.LogLevel.Debug, logMessage6);
            logger.Log(Lib.Logging.LogLevel.Trace, logMessage7);

            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GSD2AML", "Logs", filename);
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
                throw new ArgumentException($"We are missing file {filename}");
            }

        }
    }
}
