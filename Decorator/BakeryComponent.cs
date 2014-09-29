using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class BakeryComponent
    {
        public abstract string GetName();
        public abstract decimal GetPrice();
    }
}
