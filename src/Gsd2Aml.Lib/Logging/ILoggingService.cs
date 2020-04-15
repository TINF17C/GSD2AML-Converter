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

namespace Gsd2Aml.Lib.Logging
{
    /// <summary>
    /// Interface to provide logging information of the conversion process.
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// Log method which puts a message with the specific log level into the log file.
        /// </summary>
        /// <param name="level">The level of the log message.</param>
        /// <param name="message">The message of the log.</param>
        void Log(LogLevel level, string message);
    }

    /// <summary>
    /// Enum which contains all possible log levels.
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
