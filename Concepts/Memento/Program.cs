using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesProspect salesProspect = new SalesProspect();
            salesProspect.Name = "Noel van Halen";
            salesProspect.Phone = "(412) 256-0990";
            salesProspect.Budget = 25000;

            //Store internal state
            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveMemento();

            salesProspect.Name = "Leo Welch";
            salesProspect.Phone = "(310) 209-7111";
            salesProspect.Budget = 1000000;

            //Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);

            Console.ReadKey();

        }
    }
}
