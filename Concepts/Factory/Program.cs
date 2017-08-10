using System;

namespace Concepts.Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IPeople people = factory.GetPeople(PeopleType.Urban);

            Console.WriteLine(people.GetName());

            people = factory.GetPeople(PeopleType.Rural);
            Console.WriteLine(people.GetName());

            Console.ReadKey();
        }
    }
}
