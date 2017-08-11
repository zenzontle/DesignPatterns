using System;

namespace Concepts.Visitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            if (employee != null)
            {
                Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name,
                    employee.VacationDays);
            }
            else
            {
                Console.WriteLine("No employee");
            }
        }
    }
}
