using System;
using Concepts.AbstractFactory.AbstractCars;

namespace Concepts.AbstractFactory.ConcreteCars
{
    public class MercedesSportCar : SportsCar
    {
        public override void RunFast()
        {
            Console.WriteLine("I'm a Mercedes sports car running very fast!");
        }
    }
}
