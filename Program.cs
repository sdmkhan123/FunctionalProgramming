using System;

namespace FunctionalProgramming
{
    class Program
    {
        public static void LargestAmongThreeNum(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 is the largest");
                }
                else
                {
                    Console.WriteLine("Num3 is the largest");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("Num2 is the largest");
            else
                Console.WriteLine("Num3 is the largest");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("enter num1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num3 ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            LargestAmongThreeNum(num1, num2, num3);
        }
    }
}