using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("George Tobias");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n {0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");

            Console.ReadKey();
        }
    }
}
