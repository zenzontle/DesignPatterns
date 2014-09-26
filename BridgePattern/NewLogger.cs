using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class NewLogger : ILog
    {
        public void Log(string textToLog)
        {
            Console.WriteLine(String.Format("NewLog {0}", textToLog));
        }

        public void LogError(string errorToLog)
        {
            Console.WriteLine(String.Format("NewError {0}", errorToLog));
        }
    }
}
