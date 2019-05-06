using System;
using NLog;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Gui
{
    public class Logger : ILoggingService
    {
        private NLog.Logger NlogLogger { get; } = GetLogger();

        private static NLog.Logger GetLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile")
            {
                FileName = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                $@"GSD2AML\Logs\{DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}.log")
            };

            config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logfile);

            LogManager.Configuration = config;

            return LogManager.GetLogger("GSD2AML");
        }

        public void Log(Lib.Logging.LogLevel level, string message)
        {
            NLog.LogLevel logLevel;
            switch (level)
            {
                case Lib.Logging.LogLevel.Error:
                    logLevel = NLog.LogLevel.Error;
                    break;

                case Lib.Logging.LogLevel.Info:
                    logLevel = NLog.LogLevel.Info;
                    break;

                case Lib.Logging.LogLevel.Trace:
                    logLevel = NLog.LogLevel.Trace;
                    break;

                case Lib.Logging.LogLevel.Warning:
                    logLevel = NLog.LogLevel.Warn;
                    break;

                case Lib.Logging.LogLevel.Debug:
                    logLevel = NLog.LogLevel.Debug;
                    break;

                case Lib.Logging.LogLevel.Fatal:
                    logLevel = NLog.LogLevel.Fatal;
                    break;

                default:
                    logLevel = NLog.LogLevel.Off;
                    break;
            }

            NlogLogger.Log(logLevel, message);
        }
    }
}
