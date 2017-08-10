using System;

namespace Concepts.Bridge
{
    public class LegacyLogger : ILog
    {
        public void Log(string textToLog)
        {
            Console.WriteLine($"LegacyLog: {textToLog}");
        }

        public void LogError(string errorToLog)
        {
            Console.WriteLine($"LegacyError: {errorToLog}");
        }
    }
}
