using System;

namespace Concepts.Facade
{
    /// <summary>
    /// The Facade class
    /// </summary>
    public class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

            bool eligible = true;

            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoands(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
