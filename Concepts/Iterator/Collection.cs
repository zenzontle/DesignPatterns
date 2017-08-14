using System.Collections.Generic;

namespace Concepts.Iterator
{
    public class Collection : IAbstractCollection
    {
        private readonly List<Item> _items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count => _items.Count;

        public Item this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
