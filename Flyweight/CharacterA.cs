using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CharacterA : Character
    {
        public CharacterA()
        {
            _symbol = 'A';
            _height = 100;
            _width = 120;
            _ascent = 70;
            _descent = 0;
        }
        public override void Display(int pointSize)
        {
            _pointSize = pointSize;
            Console.WriteLine("{0} (pointsize {1})", _symbol, _pointSize);
        }
    }
}
