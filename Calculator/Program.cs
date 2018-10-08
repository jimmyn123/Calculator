using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // while a valid number between 1 and 4 is not inputted (can make a function to use for all three of these)
            bool valid;
            int selection;
            do
            {
                WriteLine("Choose an operation 1) Addition 2) Subtraction 3) Multiplication 4) Division: ");
                valid = int.TryParse(ReadLine(), out selection);
            } while (!valid || selection > 4 || selection < 1);

            // while a valid number is not inputted
            decimal x;
            do
            {
                WriteLine("Insert valid operand (number):");
                valid = decimal.TryParse(ReadLine(), out x);
            } while (!valid);

            // can throw these into functions to reduce redundancy...but lazy haha
            decimal y;
            do
            {
                WriteLine("Insert valid operand (number):");
                valid = decimal.TryParse(ReadLine(), out y);
            } while (!valid);


            // switch that calls each individual function
            decimal answer;
            switch (selection)
            {
                case 1:
                    answer = Add(x, y);
                    break;
                case 2:
                    answer = Subtract(x, y);
                    break;
                case 3:
                    answer = Multiply(x, y);
                    break;
                default: // defaults to 4 since we checked for 1 through 4 earlier
                    answer = Divide(x, y);
                    break;
            }

            // writes out the answer
            WriteLine($"Answer: {answer}");
        }

        // function that adds
        static decimal Add(decimal x, decimal y)
        {
            return x + y; 
        }

        // function that subtracts
        static decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }

        // function that multiplies
        static decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }

        // function that divides
        static decimal Divide(decimal x, decimal y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                // yells at people not to divide by 0
                WriteLine("Can't divide by 0!");
                return 0;
            }
        }
    }
}
