using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            _name = "Cherry";
            _price = 2;
        }
    }
}
