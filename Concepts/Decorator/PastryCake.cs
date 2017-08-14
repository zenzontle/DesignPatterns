namespace Concepts.Decorator
{
    public class PastryBase : BakeryComponent
    {
        private const string Name = "Pastry Base";
        private const decimal Price = 20;

        public override string GetName()
        {
            return Name;
        }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}
