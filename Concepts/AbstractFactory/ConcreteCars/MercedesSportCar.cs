using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.AbstractCars;

namespace AbstractFactory.ConcreteCars
{
    class MercedesSportCar : SportsCar
    {
        public override void RunFast()
        {
            Console.WriteLine("I'm a Mercedes sports car running very fast!");
        }
    }
}
