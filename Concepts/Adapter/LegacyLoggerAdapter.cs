using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class LegacyLoggerAdapter : ILog
    {
        private LegacyLogger _legacyLogger = new LegacyLogger();
        public void Log(string textToLog)
        {
            _legacyLogger.LogSomething(textToLog);
        }
    }
}
