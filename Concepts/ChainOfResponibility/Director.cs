using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponibility
{
    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, purchase.Number);
            }
            else if(_successor != null)
            {
                _successor.ProcessRequest(purchase);
            }
        }
    }
}
