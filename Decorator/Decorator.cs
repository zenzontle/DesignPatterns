using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : BakeryComponent
    {
        BakeryComponent _baseComponent = null;

        protected string _name = "Undefined Decorator";
        protected decimal _price = 0;

        protected Decorator(BakeryComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public override string GetName()
        {
            return String.Format("{0}, {1}", _baseComponent.GetName(), _name);
        }

        public override decimal GetPrice()
        {
            return _price + _baseComponent.GetPrice();
        }
    }
}
