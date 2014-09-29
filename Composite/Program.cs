using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker workerTom = new Worker("Worker Tom", 5);
            Supervisor supervisorMary = new Supervisor("Supervisor Mary", 6);
            Supervisor supervisorJerry = new Supervisor("Supervisor Jerry", 7);
            Supervisor supervisorBob = new Supervisor("Supervisor Bob", 9);
            Worker workerJimmy = new Worker("Worker Jimmy", 8);

            supervisorMary.AddSubordinate(workerTom);
            supervisorJerry.AddSubordinate(supervisorMary);
            supervisorJerry.AddSubordinate(supervisorBob);
            supervisorBob.AddSubordinate(workerJimmy);

            supervisorJerry.ShowHappiness();

            Console.ReadKey();
        }
    }
}
