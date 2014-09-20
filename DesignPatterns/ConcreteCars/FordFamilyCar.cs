using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.AbstractFactory.AbstractCars;

namespace DesignPatterns.AbstractFactory.ConcreteCars
{
    class FordFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Ford family car running slow...");
        }
    }
}
