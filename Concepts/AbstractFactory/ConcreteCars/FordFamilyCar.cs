using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.AbstractCars;

namespace AbstractFactory.ConcreteCars
{
    class FordFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Ford family car running slow...");
        }
    }
}
