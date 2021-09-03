using System;

namespace FunctionalProgramming
{
    class Program
    {
        public static void swapTwoNum(int num1, int num2)
        {
            Console.WriteLine("Before swapping num1 and num2 are " + num1 + " " + num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping num1 and num2 are " + num1 + " " + num2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("Enter num2 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1 ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            swapTwoNum(num1, num2);
        }
    }
}