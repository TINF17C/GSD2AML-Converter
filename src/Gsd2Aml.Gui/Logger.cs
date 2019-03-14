using Gsd2Aml.Lib.Logging;
using NLog;
using LogLevel = Gsd2Aml.Lib.Logging.LogLevel;

namespace Gsd2Aml.Gui
{
    class Logger : ILoggingService
    {
        private NLog.Logger NlogLogger { get; } = LogManager.GetCurrentClassLogger();

        public void Log(LogLevel level, string message)
        {
            NLog.LogLevel logLevel;
            switch (level)
            {
                case LogLevel.Error:
                    logLevel = NLog.LogLevel.Error;
                    break;

                case LogLevel.Info:
                    logLevel = NLog.LogLevel.Info;
                    break;

                case LogLevel.Trace:
                    logLevel = NLog.LogLevel.Trace;
                    break;

                case LogLevel.Warning:
                    logLevel = NLog.LogLevel.Warn;
                    break;

                case LogLevel.Debug:
                    logLevel = NLog.LogLevel.Debug;
                    break;

                case LogLevel.Fatal:
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
