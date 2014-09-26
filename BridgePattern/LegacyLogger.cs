using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class LegacyLogger : ILog
    {
        public void Log(string textToLog)
        {
            Console.WriteLine(String.Format("LegacyLog: {0}", textToLog));
        }

        public void LogError(string errorToLog)
        {
            Console.WriteLine(String.Format("LegacyError: {0}", errorToLog));
        }
    }
}
