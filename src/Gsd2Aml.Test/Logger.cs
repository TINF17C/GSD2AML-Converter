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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gsd2Aml.Test
{
    internal class Logger : ILoggingService
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
