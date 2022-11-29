using System;
using System.Data;
using System.Windows.Input;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
           int[][] matrix = new int[number][];
            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                matrix[i] = new int[line.Length];
                for (int p = 0; p < line.Length; p++)
                {
                    matrix[i][p] = int.Parse(line[p]); 
                }
            }

            
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }
                string[] parts = command.Split(" ");

                if (int.Parse(parts[1]) >= matrix.GetLength(0) || int.Parse(parts[1]) < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                
                if (int.Parse(parts[2]) >= matrix[int.Parse(parts[1])].Length || int.Parse(parts[2]) <0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (parts[0] == "add")
                {
                    
                    matrix[int.Parse(parts[1])][int.Parse(parts[2])] += int.Parse(parts[3]);
                }

                if (parts[0] == "subtract")
                {
                    
                    matrix[int.Parse(parts[1])][int.Parse(parts[2])] -= int.Parse(parts[3]);

                }
            }


            for (int i = 0; i < number; i++)
            {
                for (int r = 0; r < matrix[i].Length; r++)
                {
                    Console.Write($"{matrix[i][r]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
