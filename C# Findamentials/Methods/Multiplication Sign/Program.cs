using System;

namespace _5._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplicationSign();
        }

        private static void MultiplicationSign()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne > 0 && numberTwo > 0 && numberThree > 0)
            {
                Console.WriteLine("positive");
            }

            else if (numberOne > 0 && (numberTwo < 0 && numberThree < 0))
            {
                Console.WriteLine("positive");
            }

            else if (numberTwo > 0 && (numberOne < 0 && numberThree < 0))
            {
                Console.WriteLine("positive");
            }

            else if (numberThree > 0 && (numberOne < 0 && numberTwo < 0))
            {
                Console.WriteLine("positive");
            }

            else if (numberThree == 0 || numberOne == 0 || numberTwo == 0)
            {
                Console.WriteLine("zero");
            }

            else
            {
                Console.WriteLine("negative");
            }



        }
    }
}
