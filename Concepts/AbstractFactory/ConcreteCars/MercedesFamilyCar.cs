using System;
using Concepts.AbstractFactory.AbstractCars;

namespace Concepts.AbstractFactory.ConcreteCars
{
    public class MercedesFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Mercedes family car running very slow...");
        }
    }
}
