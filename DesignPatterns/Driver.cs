using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactory.AbstractCars;
using DesignPatterns.AbstractFactory.AbstractFactories;

namespace DesignPatterns.AbstractFactory
{
    class Driver
    {
        private readonly SportsCar _sportsCar;
        private readonly FamilyCar _familyCar;
        
        public Driver(CarFactory carFactory)
        {
            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }

        public void RunCars()
        {
            _sportsCar.RunFast();
            _familyCar.RunSlow();
        }
    }
}
