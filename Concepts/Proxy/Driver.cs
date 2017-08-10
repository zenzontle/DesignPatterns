using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Driver
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Driver(int age)
        {
            _age = age;
        }
    }
}
