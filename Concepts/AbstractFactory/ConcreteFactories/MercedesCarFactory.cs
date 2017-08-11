using Concepts.AbstractFactory.AbstractCars;
using Concepts.AbstractFactory.AbstractFactories;
using Concepts.AbstractFactory.ConcreteCars;

namespace Concepts.AbstractFactory.ConcreteFactories
{
    public class MercedesCarFactory : CarFactory
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
