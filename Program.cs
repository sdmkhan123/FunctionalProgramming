using System;

namespace FunctionalProgramming
{
    class Program
    {
        public const int flipHead = 0;
        public const int flipTail = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            int n = Convert.ToInt32(Console.ReadLine());
            int headCount = 0;
            int tailCount = 0;
            for (int i=0; i<n; i++)
            {
                Random random = new Random();
                int flipCheck = random.Next(0, 2);
                if(flipCheck == flipHead)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            double headPercentage = 100 * headCount / n;
            double tailPercentage = 100 * tailCount / n;
            Console.WriteLine("head percentage is " + headPercentage);
            Console.WriteLine("tail percentage is " + tailPercentage);
        }
    }
}
