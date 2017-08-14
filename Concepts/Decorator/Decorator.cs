namespace Concepts.Decorator
{
    public abstract class Decorator : BakeryComponent
    {
        private readonly BakeryComponent _baseComponent;

        protected string Name = "Undefined Decorator";
        protected decimal Price = 0;

        protected Decorator(BakeryComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public override string GetName()
        {
            return $"{_baseComponent.GetName()}, {Name}";
        }

        public override decimal GetPrice()
        {
            return Price + _baseComponent.GetPrice();
        }
    }
}
