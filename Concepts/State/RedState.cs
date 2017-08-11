using System;

namespace Concepts.State
{
    public class RedState : State
    {
        private double _serviceFee;

        public RedState(State state)
        {
            BalanceInternal = state.Balance;
            AccountInternal = state.Account;
            Initialize();
        }

        public override void Deposit(double amount)
        {
            BalanceInternal += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            BalanceInternal = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void Initialize()
        {
            Interest = 0;
            LowerLimit = -100;
            UpperLimit = 0;
            _serviceFee = 15;
        }

        private void StateChangeCheck()
        {
            if (BalanceInternal > UpperLimit)
            {
                AccountInternal.State = new SilverState(this);
            }
        }
    }
}
