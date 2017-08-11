using System;
using Concepts.AbstractFactory.AbstractCars;

namespace Concepts.AbstractFactory.ConcreteCars
{
    public class FordFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Ford family car running slow...");
        }
    }
}
