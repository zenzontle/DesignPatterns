using Concepts.AbstractFactory.AbstractCars;
using Concepts.AbstractFactory.AbstractFactories;

namespace Concepts.AbstractFactory
{
    public class Driver
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
