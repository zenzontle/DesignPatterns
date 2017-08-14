namespace Concepts.Decorator
{
    public class CakeBase : BakeryComponent
    {
        private const string Name = "Cake Base";
        private const decimal Price = 200;

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
