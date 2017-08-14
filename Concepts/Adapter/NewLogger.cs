using System;

namespace Concepts.Adapter
{
    public class NewLogger : ILog
    {
        public void Log(string textToLog)
        {
            Console.WriteLine($"New Logger {textToLog}");
        }
    }
}
