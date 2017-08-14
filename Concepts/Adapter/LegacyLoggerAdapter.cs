namespace Concepts.Adapter
{
    public class LegacyLoggerAdapter : ILog
    {
        private readonly LegacyLogger _legacyLogger = new LegacyLogger();
        public void Log(string textToLog)
        {
            _legacyLogger.LogSomething(textToLog);
        }
    }
}
