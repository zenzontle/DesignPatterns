using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CakeBase : BakeryComponent
    {
        private string _name = "Cake Base";
        private decimal _price = 200;

        public override string GetName()
        {
            return _name;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}
