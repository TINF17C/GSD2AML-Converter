using Gsd2Aml.Lib.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gsd2Aml.Test
{
    class Logger : ILoggingService
    {
        public void Log(LogLevel level, string message)
        {
            if (level.Equals(LogLevel.Error) || level.Equals(LogLevel.Fatal))
            {
                Assert.Fail(message);
            }
        }
    }
}
