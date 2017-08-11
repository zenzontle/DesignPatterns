﻿using System;

namespace Concepts.Command
{
    public class Calculator
    {
        private int _current;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _current += operand;
                    break;
                case '-':
                    _current -= operand;
                    break;
                case '*':
                    _current *= operand;
                    break;
                case '/':
                    _current /= operand;
                    break;
            }
            Console.WriteLine("Current value = {0, 3} (following {1} {2})", _current, @operator, operand);
        }
    }
}
