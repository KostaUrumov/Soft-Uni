using System;

namespace _4._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TribonacciSequence(1);
        }

        static void TribonacciSequence(int numberOne)
        {
            numberOne = int.Parse(Console.ReadLine());

            int[] array = new int[numberOne];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    array[i] = 1;
                    Console.Write($"{array[i]} ");
                }
                else if (i == 2)
                {
                    array[i] = array[0] + array[1];
                    Console.Write($"{array[i]} ");
                }

                else if (i > 2)
                {
                    array[i] = array[i-1] + array[i-2] + array[i-3];
                    Console.Write($"{array[i]} ");  
                }
            }
          
        }
    }
}
