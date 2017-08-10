namespace Concepts.Bridge
{
    public interface ILog
    {
        void Log(string textToLog);
        void LogError(string errorToLog);
    }
}
