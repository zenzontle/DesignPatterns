using System;

namespace Concepts.Proxy
{
    public class ProxyCar : ICar
    {
        private readonly Driver _driver;
        private readonly ICar _realCar;

        public ProxyCar(Driver driver)
        {
            _driver = driver;
            _realCar = new Car();
        }
        public void DriveCar()
        {
            if (_driver.Age <= 16)
            {
                Console.WriteLine("Sorry, age {0} is too young to drive.", _driver.Age);
            }
            else
            {
                _realCar.DriveCar();
            }
        }
    }
}
