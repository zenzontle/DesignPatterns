using System;
using Concepts.AbstractFactory.ConcreteFactories;

namespace Concepts.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            FordCarFactory fordCarFactory = new FordCarFactory();
            Driver user1 = new Driver(fordCarFactory);
            user1.RunCars();

            MercedesCarFactory mercedesCarFactory = new MercedesCarFactory();
            Driver user2 = new Driver(mercedesCarFactory);
            user2.RunCars();

            Console.ReadKey();
        }
    }
}
