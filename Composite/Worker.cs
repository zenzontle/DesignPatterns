using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Worker : IEmployee
    {
        private string _name;
        private int _happiness;

        public Worker(string name, int happiness)
        {
            _name = name;
            _happiness = happiness;
        }
        public void ShowHappiness()
        {
            Console.WriteLine(String.Format("{0} showed happiness level of {1}", _name, _happiness));
        }
    }
}
