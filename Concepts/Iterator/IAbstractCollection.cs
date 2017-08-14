using System;
namespace Concepts.Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
