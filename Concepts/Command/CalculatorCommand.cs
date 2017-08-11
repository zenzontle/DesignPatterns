using System;

namespace Concepts.Command
{
    public class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            set { _operator = value; }
        }

        public int Operand
        {
            set { _operand = value; }
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }
}
