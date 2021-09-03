using System;

namespace FunctionalProgramming
{
    class Program
    {
        public static void checkEvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Given num is even");
            }
            else
                Console.WriteLine("Given num is odd");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("Enter a num ");
            int num = Convert.ToInt32(Console.ReadLine());
            checkEvenOdd(num);
        }
    }
}