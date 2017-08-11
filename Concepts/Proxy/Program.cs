using System;

namespace Concepts.Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();

            Console.ReadKey();
        }
    }
}
