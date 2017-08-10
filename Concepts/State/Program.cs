using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Jim Johnson");

            account.Deposit(500);
            account.Deposit(300);
            account.Deposit(550);
            account.PayInterest();
            account.Withdraw(2000);
            account.Withdraw(1100);

            Console.ReadKey();
        }
    }
}
