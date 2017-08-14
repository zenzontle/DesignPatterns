using System;

namespace Concepts.Flyweight
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            Symbol = 'B';
            Height = 100;
            Width = 140;
            Ascent = 72;
            Descent = 0;
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine("{0} (pointsize {1})", Symbol, PointSize);
        }
    }
}
