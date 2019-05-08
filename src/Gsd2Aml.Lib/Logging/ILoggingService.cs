namespace Gsd2Aml.Lib.Logging
{
    /// <summary>
    /// Interface to provide logging information of the conversion process.
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// Log method which puts the message with the specific log level into the log file.
        /// </summary>
        /// <param name="level">The level of the log message.</param>
        /// <param name="message">The message of the log.</param>
        void Log(LogLevel level, string message);
    }

    /// <summary>
    /// 
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Sets the log level to info.
        /// </summary>
        Info,

        /// <summary>
        /// Sets the log level to warning.
        /// </summary>
        Warning,

        /// <summary>
        /// Sets the log level to error.
        /// </summary>
        Error,

        /// <summary>
        /// Sets the log level to trace.
        /// </summary>
        Trace,

        /// <summary>
        /// Sets the log level to debug.
        /// </summary>
        Debug,

        /// <summary>
        /// Sets the log level to fatal.
        /// </summary>
        Fatal,

        /// <summary>
        /// Sets the log level to off.
        /// </summary>
        Off
    }
}
