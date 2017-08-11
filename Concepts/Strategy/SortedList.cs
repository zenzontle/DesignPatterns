using System;
using System.Collections.Generic;

namespace Concepts.Strategy
{
    public class SortedList
    {
        private readonly List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" {0}", name);
            }
            Console.WriteLine();
        }
    }
}
