using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void tableOfPower(int n)
        {
            int power = 1;
            for ( int i=1; i<=n; i++)
            {
                Console.WriteLine(power);
                power *= 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            tableOfPower(n);
        }
    }
}
