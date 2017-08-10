using System;

namespace Concepts.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander stormCommander = new Commander();
            Infantry infantry = new Infantry();

            Commander stormCommander2 = stormCommander.Clone() as Commander;
            Infantry infantry2 = infantry.Clone() as Infantry;

            if (stormCommander2 != null)
            {
                Console.WriteLine("Firepower: {0}, Armor: {1}", stormCommander2.FirePower, stormCommander2.Armor);
            }

            if (infantry2 != null)
            {
                Console.WriteLine("Firepower: {0}, Armor: {1}", infantry2.FirePower, infantry2.Armor);
            }

            Console.ReadKey();
        }
    }
}
