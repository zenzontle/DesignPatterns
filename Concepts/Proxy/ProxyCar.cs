using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyCar : ICar
    {
        private Driver _driver;
        private ICar _realCar;

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
