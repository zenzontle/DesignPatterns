using System;

namespace Concepts.State
{
    public class Program
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
