using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid;
            int selection;
            do
            {
                WriteLine("Choose an operation 1) Addition 2) Subtraction 3) Division 4) Multiplication: ");
                valid = int.TryParse(ReadLine(), out selection);
            } while (!valid || selection > 4 || selection < 1);

            decimal x;
            do
            {
                WriteLine("Insert valid operand (number):");
                valid = decimal.TryParse(ReadLine(), out x);
            } while (!valid);

            decimal y;
            do
            {
                WriteLine("Insert valid operand (number):");
                valid = decimal.TryParse(ReadLine(), out y);
            } while (!valid);

            switch (selection)
            {
                case 1:
                    Add(x, y);
                    break;
                case 2:
                    Subtract(x, y);
                    break;
                case 3:
                    Multiply(x, y);
                    break;
                default: // defaults to 4 since we checked for 1 through 4 earlier
                    Divide(x, y);
                    break;
            }
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
