using System;

namespace Concepts.Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalesProspect salesProspect = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000
            };

            //Store internal state
            ProspectMemory prospectMemory = new ProspectMemory {Memento = salesProspect.SaveMemento()};

            salesProspect.Name = "Leo Welch";
            salesProspect.Phone = "(310) 209-7111";
            salesProspect.Budget = 1000000;

            //Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);

            Console.ReadKey();
        }
    }
}
