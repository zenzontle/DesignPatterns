using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    class Program
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
