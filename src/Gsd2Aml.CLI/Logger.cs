/*
 *  Copyright (C) 2019 GSD2AML Team (Nico Dietz, Steffen Gerdes, Constantin Ruhdorfer,
 *  Jonas Komarek, Phuc Quang Vu, Michael Weidmann)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published by
 *  the Free Software Foundation version 3 of the License.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
