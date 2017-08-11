namespace Concepts.State
{
    public class GoldState : State
    {
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
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
            Interest = 0.05;
            LowerLimit = 1000;
            UpperLimit = 10000000;
        }

        private void StateChangeCheck()
        {
            if (BalanceInternal < 0)
            {
                AccountInternal.State = new RedState(this);
            }
            else if (BalanceInternal < LowerLimit)
            {
                AccountInternal.State = new SilverState(this);
            }
        }
    }
}
