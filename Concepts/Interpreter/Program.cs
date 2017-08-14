using System;
using System.Collections.Generic;

namespace Concepts.Interpreter
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpreter(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            Console.ReadKey();
        }
    }
}
