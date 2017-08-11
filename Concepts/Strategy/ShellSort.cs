using System;
using System.Collections.Generic;

namespace Concepts.Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); //not implemented
            Console.WriteLine("ShellSorted list");
        }
    }
}
