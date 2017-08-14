using System;

namespace Concepts.Adapter
{
    public class LegacyLogger
    {
        public void LogSomething(string textToLog)
        {
            Console.WriteLine($"Legacy Logger: {textToLog}");
        }
    }
}
