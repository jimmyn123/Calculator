using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            }
        }
    }
}
