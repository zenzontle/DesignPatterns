using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Supervisor : IEmployee
    {
        private string _name;
        private int _happiness;

        private List<IEmployee> subordinate = new List<IEmployee>();

        public Supervisor(string name, int happiness)
        {
            _name = name;
            _happiness = happiness;
        }

        public void ShowHappiness()
        {
            Console.WriteLine(String.Format("{0} showed happiness level of {1}", _name, _happiness));
            foreach (IEmployee employee in subordinate)
            {
                employee.ShowHappiness();
            }
        }
        public void AddSubordinate(IEmployee employee)
        {
            subordinate.Add(employee);
        }
    }
}
