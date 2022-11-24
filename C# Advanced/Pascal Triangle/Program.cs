using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long[][] pascal = new long[number][];
            for (int rows = 0; rows < number; rows++)
            {
                if (rows == 0)
                {
                    pascal[rows] = new long[1];
                    pascal[rows][0] = 1;
                }
                if (rows > 0)
                {
                    pascal[rows] = new long[rows+1];
                    for (int cols = 0; cols < rows+1; cols++)
                    {
                        if (cols == 0)
                        {
                            pascal[rows][cols] = 1;
                        }
                        else if (cols == rows)
                        {
                            pascal[rows][cols] = 1;
                            
                        }
                        else if (cols > 0)
                        {
                            pascal[rows][cols] = pascal[rows - 1][cols-1] + pascal[rows-1][cols];
                        }
                    }
                }
                
            }


            for (int rows = 0; rows < number; rows++)
            {
                for (int cols = 0; cols < pascal[rows].Length; cols++)
                {
                    Console.Write($"{pascal[rows][cols]} ");
                }
                Console.WriteLine();

            }
        }
    }
}
