using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void PrimeFactorization(int num)
        {
            Console.Write("Prime factors of a given num are ");
            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(num); i++)
            {
                while(num%i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            if (num > 2)
                Console.Write(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("enter the value of n");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeFactorization(num);
        }
    }
}
