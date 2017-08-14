namespace Concepts.Decorator
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Cream";
            Price = 1;
        }
    }
}
