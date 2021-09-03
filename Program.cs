using System;

namespace FunctionalProgramming
{
    class Program
    {
        public static void toCheckAlphabet(char ch)
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is consonant");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.Write("Input an Alphabet (a-z OR A-Z) : ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            toCheckAlphabet(ch);
        }
    }
}