using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class BridgeLog : ILogBridge
    {
        private ILog _log;
        public BridgeLog(ILog log)
        {
            _log = log;
        }
        public void CallLog(string textToLog)
        {
            _log.Log(textToLog);
        }

        public void CallLogError(string errorToLog)
        {
            _log.LogError(errorToLog);
        }
    }
}
