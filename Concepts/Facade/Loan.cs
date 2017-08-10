using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoands(Customer customer)
        {
            Console.WriteLine(String.Format("Check loands for {0}", customer.Name));
            return true;
        }
    }
}
