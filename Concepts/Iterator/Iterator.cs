namespace Concepts.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private readonly Collection _collection;
        private int _current;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current];
        }

        public Item Next()
        {
            _current += Step;
            if (!IsDone)
            {
                return _collection[_current];
            }
            return null;
        }

        public int Step { get; set; } = 1;

        public bool IsDone => _current >= _collection.Count;

        public Item CurrentItem => _collection[_current];
    }
}
