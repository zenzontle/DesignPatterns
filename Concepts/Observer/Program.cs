﻿using System;

namespace Concepts.Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 120);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            ibm.Price = 120.75;

            Console.ReadKey();
        }
    }
}
