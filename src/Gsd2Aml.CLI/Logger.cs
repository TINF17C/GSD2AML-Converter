using Gsd2Aml.Lib.Logging;
using NLog;

namespace Gsd2Aml.Cli
{
    /// <summary>
    /// The logger instance of the CLI.
    /// </summary>
    public class Logger : ILoggingService
    {
        private NLog.Logger NlogLogger { get; } = LogManager.GetLogger("cli_logger");
        
        /// <summary>
        /// Logs a message to the specified log level using NLog.
        /// </summary>
        /// <param name="level">The level on which to log on.</param>
        /// <param name="message">The log message.</param>
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
