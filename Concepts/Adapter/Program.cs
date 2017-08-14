using System;

namespace Concepts.Adapter
{
    public class Program
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
