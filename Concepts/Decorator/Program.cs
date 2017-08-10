using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeBase cakeBase = new CakeBase();
            PrintProductDetails(cakeBase);

            CreamDecorator creamCake = new CreamDecorator(cakeBase);
            PrintProductDetails(creamCake);

            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);

            ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
            PrintProductDetails(scentedCake);

            NameCardDecorator nameCardCake = new NameCardDecorator(scentedCake);
            PrintProductDetails(nameCardCake);

            PastryBase pastryBase = new PastryBase();
            PrintProductDetails(pastryBase);

            CreamDecorator creamPastry = new CreamDecorator(pastryBase);
            CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
            PrintProductDetails(cherryPastry);

            Console.ReadKey();
        }

        static void PrintProductDetails(BakeryComponent bakeryComponent)
        {
            Console.WriteLine("Item: {0}, Price: {1}\n", bakeryComponent.GetName(), bakeryComponent.GetPrice());
        }
    }
}
