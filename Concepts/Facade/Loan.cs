using System;

namespace Concepts.Facade
{
    public class Loan
    {
        public bool HasNoBadLoands(Customer customer)
        {
            Console.WriteLine($"Check loands for {customer.Name}");
            return true;
        }
    }
}
