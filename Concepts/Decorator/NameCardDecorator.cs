using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class NameCardDecorator : Decorator
    {
        private int _discountRate = 5;

        public NameCardDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            _name = "Name Card";
            _price = 4;
        }

        public override string GetName()
        {
            return base.GetName() + String.Format("\n Please collect your discount card for {0}%", _discountRate);
        }
    }
}
