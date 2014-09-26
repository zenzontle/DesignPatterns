using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            LegacyLogger legacyLogger = new LegacyLogger();
            legacyLogger.Log("leg log");
            legacyLogger.LogError("err log");

            NewLogger newLogger = new NewLogger();
            newLogger.Log("new log");
            newLogger.Log("new err");

            BridgeLog bridgeLog = new BridgeLog(legacyLogger);
            bridgeLog.CallLog("bridge leg log");
            bridgeLog.CallLogError("bridge leg err");

            bridgeLog = new BridgeLog(newLogger);
            bridgeLog.CallLog("bridge new log");
            bridgeLog.CallLogError("bridge new err");

            Console.ReadKey();
        }
    }
}
