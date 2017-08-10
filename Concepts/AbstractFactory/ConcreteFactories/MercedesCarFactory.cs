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
