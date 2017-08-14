using System;

namespace Concepts.Flyweight
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string document = "AABBAB";
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
