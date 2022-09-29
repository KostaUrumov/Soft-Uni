using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PalidromeIntegers("");

        }

        private static void PalidromeIntegers(string number)
        {
            while (true)
            {
                number = Console.ReadLine();

                if (number == "END")
                {
                    break;
                }
                string numberBackwards = "";

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    numberBackwards += number[i];
                }

                if (numberBackwards == number)
                {
                    Console.WriteLine("true");
                }

                else 
                {
                    Console.WriteLine("false");
                }

            }
        }
    }
}
