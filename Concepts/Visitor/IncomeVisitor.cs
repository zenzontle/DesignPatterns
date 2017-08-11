using System;

namespace Concepts.Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            if (employee != null)
            {
                employee.Income *= 1.10;
                Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.Income);
            }
            else
            {
                Console.WriteLine("No employee");
            }
        }
    }
}
