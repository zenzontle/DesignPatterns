using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IPeople people = factory.GetPeople(PeopleType.URBAN);

            Console.WriteLine(people.GetName());

            people = factory.GetPeople(PeopleType.RURAL);
            Console.WriteLine(people.GetName());

            Console.ReadKey();
        }
    }
}
