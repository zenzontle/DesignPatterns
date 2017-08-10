using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// The Flyweight abstract class
    /// </summary>
    abstract class Character
    {
        protected char _symbol;
        protected int _width;
        protected int _height;
        protected int _ascent;
        protected int _descent;
        protected int _pointSize;

        public abstract void Display(int pointSize);
    }
}
