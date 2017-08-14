namespace Concepts.Decorator
{
    public class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Artificial Scent";
            Price = 3;
        }
    }
}
