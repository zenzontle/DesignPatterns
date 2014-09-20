using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.AbstractFactory.AbstractCars;

namespace DesignPatterns.AbstractFactory.ConcreteCars
{
    class FordSportsCar : SportsCar
    {
        public override void RunFast()
        {
            Console.WriteLine("I'm a Ford car running fast!");
        }
    }
}
