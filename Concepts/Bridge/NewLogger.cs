using System;

namespace Concepts.Bridge
{
    public class NewLogger : ILog
    {
        public void Log(string textToLog)
        {
            Console.WriteLine($"NewLog {textToLog}");
        }

        public void LogError(string errorToLog)
        {
            Console.WriteLine($"NewError {errorToLog}");
        }
    }
}
