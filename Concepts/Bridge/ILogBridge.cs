namespace Concepts.Bridge
{
    public interface ILogBridge
    {
        void CallLog(string textToLog);
        void CallLogError(string errorToLog);
    }
}
