using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void HarmonicNthNumber(int N)
        {
            float harmonic = 1F;
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.Write("the nth Harmonic num is " + harmonic);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            HarmonicNthNumber(n);
        }
    }
}