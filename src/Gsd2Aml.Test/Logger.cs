using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gsd2Aml.Lib.Logging;

namespace Gsd2Aml.Test
{
    class Logger : Lib.Logging.ILoggingService
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(level.ToString() + message);
        }
    }
}
