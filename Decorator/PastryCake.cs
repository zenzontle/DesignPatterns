using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PastryBase : BakeryComponent
    {
        private string _name = "Pastry Base";
        private decimal _price = 20;

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
