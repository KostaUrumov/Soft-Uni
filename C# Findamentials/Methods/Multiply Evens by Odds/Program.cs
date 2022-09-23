using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs (int.Parse(Console.ReadLine()));
            int numberOdd = GetOddSum(number, 1);
            int numberEven = GetEvenSum(number, 1);
            Console.WriteLine(Multiply(numberOdd, numberEven));
        }


        static int GetOddSum(int number, int odd)
        {
            int digit = 0;
            int oddSum = 0;

            while (number > 0)
            {
                digit = number % 10;
                number = number / 10;
                if (digit % 2 == 1)
                {
                    oddSum += digit;
                }

            }
            return oddSum;

        }


        static int GetEvenSum(int number, int even)
        {
            int digit = 0;
            int evenSum = 0;

            while (number > 0)
            {
                digit = number % 10;
                number = number / 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }

            }
            return evenSum;

        }


        static int Multiply(int numberOdd, int numberEven)
        {
            int result = numberOdd * numberEven;
            return result;
        }






    }
}
