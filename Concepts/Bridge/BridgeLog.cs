namespace Concepts.Bridge
{
    public class BridgeLog : ILogBridge
    {
        private readonly ILog _log;
        public BridgeLog(ILog log)
        {
            _log = log;
        }
        public void CallLog(string textToLog)
        {
            _log.Log(textToLog);
        }

        public void CallLogError(string errorToLog)
        {
            _log.LogError(errorToLog);
        }
    }
}
