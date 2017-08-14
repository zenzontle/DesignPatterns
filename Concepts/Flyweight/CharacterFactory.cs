using System.Collections.Generic;

namespace Concepts.Flyweight
{
    /// <summary>
    /// Flyweight factory
    /// </summary>
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character;
            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA();
                        break;
                    case 'B': character = new CharacterB();
                        break;
                    default:
                        // This is wrong, but I'm not going to create Character classes for all the letters.
                        character = new CharacterA();
                        break;
                }
                _characters.Add(key, character);
            }
            return character;
        }
    }
}
