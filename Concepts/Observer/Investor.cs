using System;

namespace Concepts.Observer
{
    public class Investor : IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:c}", _name, stock.Symbol, stock.Price);
        }

        public Stock Stock { get; set; }
    }
}
