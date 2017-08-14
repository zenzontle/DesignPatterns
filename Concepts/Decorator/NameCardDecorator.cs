namespace Concepts.Decorator
{
    public class NameCardDecorator : Decorator
    {
        private const int DiscountRate = 5;

        public NameCardDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Name Card";
            Price = 4;
        }

        public override string GetName()
        {
            return base.GetName() + $"\n Please collect your discount card for {DiscountRate}%";
        }
    }
}
