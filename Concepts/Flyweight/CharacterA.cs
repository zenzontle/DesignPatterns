using System;

namespace Concepts.Flyweight
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            Symbol = 'A';
            Height = 100;
            Width = 120;
            Ascent = 70;
            Descent = 0;
        }
        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine("{0} (pointsize {1})", Symbol, PointSize);
        }
    }
}
