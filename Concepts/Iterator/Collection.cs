﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Collection : IAbstractCollection
    {
        private List<Item> _items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public Item this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
