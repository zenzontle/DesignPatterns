namespace Concepts.State
{
    public class SilverState : State
    {
        public SilverState(State state)
            : this(state.Balance, state.Account)
        {
        }
        
        public SilverState(double balance, Account account)
        {
            BalanceInternal = balance;
            AccountInternal = account;
            Initialize();
        }

        public override void Deposit(double amount)
        {
            BalanceInternal += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            BalanceInternal -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            BalanceInternal += Interest * BalanceInternal;
            StateChangeCheck();
        }

        private void Initialize()
        {
            Interest = 0;
            LowerLimit = 0;
            UpperLimit = 1000;
        }

        private void StateChangeCheck()
        {
            if (BalanceInternal < LowerLimit)
            {
                AccountInternal.State = new RedState(this);
            }
            else if (BalanceInternal > UpperLimit)
            {
                AccountInternal.State = new GoldState(this);
            }
        }
    }
}
