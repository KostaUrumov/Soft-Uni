using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = 0;
            int size = int.Parse(Console.ReadLine());
            string[,] theRoute = new string[size, size];
            string racingCarNumber = Console.ReadLine();

            for (int rows = 0; rows < size; rows++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ");

                for (int cols = 0; cols < size; cols++)
                {
                    theRoute[rows, cols] = line[cols];
                }

            }

            int currentRow = 0;
            int currentCol = 0;
            int hitFinal = 0;

            while (hitFinal == 0)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (command == "down")
                {
                    currentRow++;
                    if (theRoute[currentRow, currentCol] == "T")
                    {
                        kilometers += 30;
                        theRoute[currentRow, currentCol] = ".";

                        for (int row = 0; row < size; row++)
                        {
                            for (int col = 0; col < size; col++)
                            {
                                if (theRoute[row, col] == "T")
                                {
                                    currentCol = col;
                                    currentRow = row;
                                    theRoute[currentRow, currentCol] = ".";
                                }
                            }

                        }
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == ".")
                    {
                        theRoute[currentRow, currentCol] = ".";
                        kilometers += 10;
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == "F")
                    {
                        hitFinal++;
                        theRoute[currentRow, currentCol] = "C";
                        kilometers += 10;

                        continue;
                    }
                }

                if (command == "up")
                {
                    currentRow--;
                    if (theRoute[currentRow, currentCol] == "T")
                    {
                        kilometers += 30;
                        theRoute[currentRow, currentCol] = ".";

                        for (int row = 0; row < size; row++)
                        {
                            for (int col = 0; col < size; col++)
                            {
                                if (theRoute[row, col] == "T")
                                {
                                    currentCol = col;
                                    currentRow = row;
                                    theRoute[currentRow, currentCol] = ".";
                                }
                            }

                        }
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == ".")
                    {
                        kilometers += 10;
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == "F")
                    {
                        hitFinal++;
                        theRoute[currentRow, currentCol] = "C";
                        kilometers += 10;

                        continue;
                    }
                }

                if (command == "right")
                {
                    currentCol++;
                    if (theRoute[currentRow, currentCol] == "T")
                    {
                        kilometers += 30;
                        theRoute[currentRow, currentCol] = ".";

                        for (int row = 0; row < size; row++)
                        {
                            for (int col = 0; col < size; col++)
                            {
                                if (theRoute[row, col] == "T")
                                {
                                    currentCol = col;
                                    currentRow = row;
                                    theRoute[currentRow, currentCol] = ".";
                                }
                            }


                        }
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == ".")
                    {
                        kilometers += 10;
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == "F")
                    {
                        hitFinal++;
                        kilometers += 10;
                        theRoute[currentRow, currentCol] = "C";

                        continue;
                    }
                }

                if (command == "left")
                {
                    currentCol--;
                    if (theRoute[currentRow, currentCol] == "T")
                    {
                        kilometers += 30;
                        theRoute[currentRow, currentCol] = ".";

                        for (int row = 0; row < size; row++)
                        {
                            for (int col = 0; col < size; col++)
                            {
                                if (theRoute[row, col] == "T")
                                {
                                    currentCol = col;
                                    currentRow = row;
                                    theRoute[currentRow, currentCol] = ".";
                                }
                            }

                        }
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == ".")
                    {
                        kilometers += 10;
                        continue;
                    }
                    if (theRoute[currentRow, currentCol] == "F")
                    {
                        hitFinal++;
                        kilometers += 10;
                        theRoute[currentRow, currentCol] = "C";
                        continue;
                    }
                }


            }

            if (hitFinal == 0)
            {
                Console.WriteLine($"Racing car {racingCarNumber} DNF.");
                Console.WriteLine($"Distance covered {kilometers} km.");
                theRoute[currentRow, currentCol] = "C";
                for (int i = 0; i < size; i++)
                {
                    for (int p = 0; p < size; p++)
                    {
                        Console.Write(theRoute[i, p]);
                    }
                    Console.WriteLine();

                }
            }

            if (hitFinal == 1)
            {
                Console.WriteLine($"Racing car {racingCarNumber} finished the stage!");
                Console.WriteLine($"Distance covered {kilometers} km.");
                theRoute[currentRow, currentCol] = "C";
                for (int i = 0; i < size; i++)
                {
                    for (int p = 0; p < size; p++)
                    {
                        Console.Write(theRoute[i, p]);
                    }
                    Console.WriteLine();

                }
            }



        }
    }
}
