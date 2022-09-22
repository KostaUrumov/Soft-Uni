using System;

namespace _4._Print_Triangle
{
    internal class Program
    {
        static void printTriangle()
        {
            int numberLines = int.Parse(Console.ReadLine());
            int [] number = new int[numberLines];
            
            for (int i = 0; i < numberLines; i++)
            {
                number[i] = i + 1;
            }


            for (int i = 0; i < numberLines; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(number[i]);
                }

                else if (i > 0)
                {
                    for (int t = 0; t <= i; t++)
                    {
                        Console.Write($"{number[t]} ");
                    }
                    Console.WriteLine();
                }
            }

            for (int i = number.Length - 1; i >=  0 ; i--)
            {
                for (int p = 0; p < i; p++)
                {
                    Console.Write($"{number[p]} ");
                }
                Console.WriteLine();
                    
               
            }         
            
        }

        static void Main(string[] args)
        {
        printTriangle();
        }
    }
}
