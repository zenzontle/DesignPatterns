using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactory.AbstractCars;

namespace DesignPatterns.AbstractFactory.AbstractFactories
{
    abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
}
