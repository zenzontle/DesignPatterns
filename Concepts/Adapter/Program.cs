using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            LegacyLogger legacyLogger = new LegacyLogger();
            legacyLogger.LogSomething("legacy");

            LegacyLoggerAdapter legacyLoggerAdapter = new LegacyLoggerAdapter();
            legacyLoggerAdapter.Log("adapter");

            NewLogger newLogger = new NewLogger();
            newLogger.Log("new");

            Console.ReadKey();
        }
    }
}
