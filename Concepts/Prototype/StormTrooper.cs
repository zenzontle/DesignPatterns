using System;

namespace Concepts.Prototype
{
    public abstract class StormTrooper:ICloneable
    {
        public int FirePower { get; set; }
        public int Armor { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
