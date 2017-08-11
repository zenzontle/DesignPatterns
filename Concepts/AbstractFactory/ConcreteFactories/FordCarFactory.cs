using Concepts.AbstractFactory.AbstractCars;
using Concepts.AbstractFactory.AbstractFactories;
using Concepts.AbstractFactory.ConcreteCars;

namespace Concepts.AbstractFactory.ConcreteFactories
{
    public class FordCarFactory : CarFactory
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
