using System;
using System.Collections.Generic;

namespace Concepts.Visitor
{
    public class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in _employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
