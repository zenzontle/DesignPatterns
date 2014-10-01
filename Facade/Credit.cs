using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine(String.Format("Check credit for {0}", customer.Name));
            return true;
        }
    }
}
