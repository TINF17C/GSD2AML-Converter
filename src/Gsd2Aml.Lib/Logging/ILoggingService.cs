namespace Gsd2Aml.Lib.Logging
{
    public interface ILoggingService
    {
        void Log(LogLevel level, string message);
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Trace,
        Debug,
        Fatal,
        Off
    }
}
