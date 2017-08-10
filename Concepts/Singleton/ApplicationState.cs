using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ApplicationState
    {
        private static volatile ApplicationState _instance;
        private static object _lock = new object();

        public static ApplicationState GetState()
        {
            if (_instance == null)
            { 
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ApplicationState();
                    }
                }
            }
            return _instance;
        }

        public string LoginId { get; set; }
        public int MaxSize { get; set; }
    }
}
