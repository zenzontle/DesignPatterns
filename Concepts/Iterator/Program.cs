using System;

namespace Concepts.Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Build a collection
            Collection collection = new Collection
            {
                [0] = new Item("Item 0"),
                [1] = new Item("Item 1"),
                [2] = new Item("Item 2"),
                [3] = new Item("Item 3"),
                [4] = new Item("Item 4"),
                [5] = new Item("Item 5"),
                [6] = new Item("Item 6"),
                [7] = new Item("Item 7"),
                [8] = new Item("Item 8")
            };

            //Create iterator
            Iterator iterator = new Iterator(collection) {Step = 2};

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
