using System;
using Concepts.AbstractFactory.AbstractCars;

namespace Concepts.AbstractFactory.ConcreteCars
{
    public class FordSportsCar : SportsCar
    {
        public override void RunFast()
        {
            Console.WriteLine("I'm a Ford car running fast!");
        }
    }
}
