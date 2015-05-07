using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.AbstractCars;

namespace AbstractFactory.ConcreteCars
{
    class MercedesFamilyCar : FamilyCar
    {
        public override void RunSlow()
        {
            Console.WriteLine("I'm a Mercedes family car running very slow...");
        }
    }
}
