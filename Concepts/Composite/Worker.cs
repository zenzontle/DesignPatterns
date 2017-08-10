using System;

namespace Concepts.Composite
{
    public class Worker : IEmployee
    {
        private readonly string _name;
        private readonly int _happiness;

        public Worker(string name, int happiness)
        {
            _name = name;
            _happiness = happiness;
        }
        public void ShowHappiness()
        {
            Console.WriteLine($"{_name} showed happiness level of {_happiness}");
        }
    }
}
