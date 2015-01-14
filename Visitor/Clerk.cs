using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Clerk : Employee
    {
        public Clerk()
            : base("Hank", 25000, 14)
        {
        }
    }
}
