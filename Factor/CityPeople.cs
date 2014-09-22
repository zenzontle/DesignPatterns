using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CityPeople : IPeople
    {
        public string GetName()
        {
            return "City Guy";
        }
    }
}
