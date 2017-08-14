namespace Concepts.Decorator
{
    public class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Cherry";
            Price = 2;
        }
    }
}
