using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.AbstractFactory.AbstractCars;

namespace DesignPatterns.AbstractFactory.ConcreteCars
{
    class MercedesFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Mercedes family car running very slow...");
        }
    }
}
