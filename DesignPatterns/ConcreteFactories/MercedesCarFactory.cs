using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactory.AbstractCars;
using DesignPatterns.AbstractFactory.AbstractFactories;
using DesignPatterns.AbstractFactory.ConcreteCars;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    class MercedesCarFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }
}
