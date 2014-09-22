using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationState applicationState = ApplicationState.GetState();
            applicationState.LoginId = "kanasz";
            applicationState.MaxSize = 1024;

            ApplicationState applicationState2 = ApplicationState.GetState();

            Console.WriteLine(applicationState2.LoginId);
            Console.WriteLine(applicationState2.MaxSize);
            Console.WriteLine(applicationState == applicationState2);

            Console.ReadKey();
        }
    }
}
