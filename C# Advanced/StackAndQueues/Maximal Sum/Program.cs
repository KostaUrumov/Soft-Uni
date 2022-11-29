using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ");
            int[,] matrixBig = new int[int.Parse(size[0]), int.Parse(size[1])];

            for (int rows = 0; rows < matrixBig.GetLength(0) ; rows++)
            {
                string[] numbers = Console.ReadLine().Split(" ");
                for (int cols = 0; cols < matrixBig.GetLength(1); cols++)
                {
                    matrixBig[rows, cols] = int.Parse(numbers[cols]);

                }
            }


            int maximalSum = 0;
            int startRow = 0;
            int startCol = 0;

            for (int rows = 0; rows < matrixBig.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < matrixBig.GetLength(1)-2; cols++)
                {
                    int currentSum = 0;

                    for (int initialRows = rows; initialRows < rows+3; initialRows++)
                    {
                        for (int initialCols = cols; initialCols < cols+3; initialCols++)
                        {
                            currentSum += matrixBig[initialRows, initialCols];

                        }

                    }

                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        startRow = rows;
                        startCol = cols;
                    }
                }
            }


            Console.WriteLine($"Sum = {maximalSum}");
            for (int rows = startRow; rows < startRow + 3; rows++)
            {
                for (int cols = startCol; cols < startCol + 3; cols++)
                {
                    Console.Write($"{matrixBig[rows,cols]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
