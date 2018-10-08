using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid;
            do
            {
                WriteLine("Choose an operation 1) Addition 2) Subtraction 3) Division 4) Multiplication: ");
                int selection;
                valid = int.TryParse(ReadLine(), out selection);
            } while (!valid);

            WriteLine("Insert first operand:");
            decimal x;
            decimal.TryParse(ReadLine(), out x);
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }

        static decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }

        static decimal Divide(decimal x, decimal y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException ex)
            {
                WriteLine("Can't divide by 0!");
                return 0;
            }
        }
    }
}
