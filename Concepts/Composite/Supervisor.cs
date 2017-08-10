using System;
using System.Collections.Generic;

namespace Concepts.Composite
{
    public class Supervisor : IEmployee
    {
        private readonly string _name;
        private readonly int _happiness;

        private readonly List<IEmployee> _subordinate = new List<IEmployee>();

        public Supervisor(string name, int happiness)
        {
            _name = name;
            _happiness = happiness;
        }

        public void ShowHappiness()
        {
            Console.WriteLine($"{_name} showed happiness level of {_happiness}");
            foreach (IEmployee employee in _subordinate)
            {
                employee.ShowHappiness();
            }
        }
        public void AddSubordinate(IEmployee employee)
        {
            _subordinate.Add(employee);
        }
    }
}
