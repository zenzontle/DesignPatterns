using System;

namespace Concepts.State
{
    public class Account
    {
        private readonly string _owner;

        public Account(string owner)
        {
            _owner = owner;
            State = new SilverState(0, this);
        }

        public double Balance => State.Balance;

        public State State { get; set; }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Owner {0} --- ", _owner);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}", State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Owner {0} --- ", _owner);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}", State.GetType().Name);
            Console.WriteLine("");
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Owner {0} --- ", _owner);
            Console.WriteLine("Interest paid ---");
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}", State.GetType().Name);
            Console.WriteLine("");
        }
    }
}
