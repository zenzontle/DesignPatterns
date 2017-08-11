using Concepts.AbstractFactory.AbstractCars;

namespace Concepts.AbstractFactory.AbstractFactories
{
    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
}
