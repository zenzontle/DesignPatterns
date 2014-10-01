using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string document = "AABBAB";
            char[] chars = document.ToCharArray();

            CharacterFactory characterFactory = new CharacterFactory();

            int pointSize = 10;

            foreach (char documentChars in chars)
            {
                pointSize++;
                Character character = characterFactory.GetCharacter(documentChars);
                character.Display(pointSize);
            }

            Console.ReadKey();
        }
    }
}
