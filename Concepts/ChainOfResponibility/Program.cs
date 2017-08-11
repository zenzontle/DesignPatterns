using System;

namespace Concepts.ChainOfResponibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director larry = new Director();
            VicePresident sam = new VicePresident();
            President tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            //Generate and process purchase requests
            Purchase purchase = new Purchase(2034, 350, "Assets");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100, "Project Y");
            larry.ProcessRequest(purchase);

            Console.ReadKey();
        }
    }
}
