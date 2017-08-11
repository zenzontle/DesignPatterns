using System;

namespace Concepts.Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Directory());
            employees.Attach(new President());

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());

            Console.ReadKey();
        }
    }
}
