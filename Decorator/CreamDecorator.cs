using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            _name = "Cream";
            _price = 1;
        }
    }
}
