using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractCars;
using AbstractFactory.AbstractFactories;
using AbstractFactory.ConcreteCars;

namespace AbstractFactory.ConcreteFactories
{
    class FordCarFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new FordSportsCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new FordFamilyCar();
        }
    }
}
