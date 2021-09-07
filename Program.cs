using System;

namespace FunctionalProgramming
{
    class Program
    {
        public static void QuotientAndRemainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("Enter Dividend ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            QuotientAndRemainder(dividend, divisor);
        }
    }
}