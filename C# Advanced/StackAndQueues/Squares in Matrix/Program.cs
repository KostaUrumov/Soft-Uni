using System;
using System.Data;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ");
            string[,] theMatrix = new string[int.Parse(numbers[0]), int.Parse(numbers[1])];

            for (int rows = 0; rows < theMatrix.GetLength(0); rows++)
            {
                string[] command = Console.ReadLine().Split(" ");
                for (int cols = 0; cols < theMatrix.GetLength(1); cols++)
                {
                    theMatrix[rows, cols] = command[cols];
                }

            }

            int square = 0;
            for (int row = 0; row < theMatrix.GetLength(0)-1; row++)
            {
                for (int cols = 0; cols < theMatrix.GetLength(1)-1; cols++)
                {
                    if (theMatrix[row,cols] == theMatrix[row, cols+1] && theMatrix[row+1,cols] == theMatrix[row, cols] && theMatrix[row, cols] == theMatrix[row+1, cols+1])
                    {
                        square++;
                    }

                }

            }

            Console.WriteLine(square);
           
        }
    }
}
