using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum PeopleType
	{
        RURAL,
        URBAN
	}

    public class Factory
    {
        public IPeople GetPeople(PeopleType type)
        {
            IPeople people = null;
            switch (type)
            {
                case PeopleType.RURAL:
                    people = new Villagers();
                    break;
                case PeopleType.URBAN:
                    people = new CityPeople();
                    break;
                default:
                    break;
            }
            return people;
        }
    }
}
