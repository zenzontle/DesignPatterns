using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface ILogBridge
    {
        void CallLog(string textToLog);
        void CallLogError(string errorToLog);
    }
}
