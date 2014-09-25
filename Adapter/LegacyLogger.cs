using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class LegacyLogger
    {
        public void LogSomething(string textToLog)
        {
            Console.WriteLine(string.Format("Legacy Logger: {0}", textToLog));
        }
    }
}
