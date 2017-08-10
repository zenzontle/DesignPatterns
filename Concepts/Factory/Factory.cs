namespace Concepts.Factory
{
    public enum PeopleType
	{
        None,
        Rural,
        Urban
	}

    public class Factory
    {
        public IPeople GetPeople(PeopleType type)
        {
            IPeople people = null;
            switch (type)
            {
                case PeopleType.Rural:
                    people = new Villagers();
                    break;
                case PeopleType.Urban:
                    people = new CityPeople();
                    break;
            }
            return people;
        }
    }
}
