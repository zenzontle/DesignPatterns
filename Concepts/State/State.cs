namespace Concepts.State
{
    public abstract class State
    {
        protected Account AccountInternal;
        protected double BalanceInternal;

        protected double Interest;
        protected double LowerLimit;
        protected double UpperLimit;

        public Account Account
        {
            get { return AccountInternal; }
            set { AccountInternal = value; }
        }

        public double Balance
        {
            get { return BalanceInternal; }
            set { BalanceInternal = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
