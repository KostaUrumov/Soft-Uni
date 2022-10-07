using System;
using System.Numerics;

namespace _2._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            BigInteger bigInteger = integer;
            for (int i = 2; i < integer; i++)
            {
                bigInteger *= i;
            }

            Console.WriteLine(bigInteger);

        }
    }
}
