﻿namespace Concepts.Flyweight
{
    /// <summary>
    /// The Flyweight abstract class
    /// </summary>
    public abstract class Character
    {
        protected char Symbol;
        protected int Width;
        protected int Height;
        protected int Ascent;
        protected int Descent;
        protected int PointSize;

        public abstract void Display(int pointSize);
    }
}
