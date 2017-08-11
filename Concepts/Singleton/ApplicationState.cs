namespace Concepts.Singleton
{
    public sealed class ApplicationState
    {
        private static volatile ApplicationState _instance;
        private static readonly object Lock = new object();

        public static ApplicationState GetState()
        {
            if (_instance != null) return _instance;
            lock (Lock)
            {
                if (_instance == null)
                {
                    _instance = new ApplicationState();
                }
            }
            return _instance;
        }

        public string LoginId { get; set; }
        public int MaxSize { get; set; }
    }
}
