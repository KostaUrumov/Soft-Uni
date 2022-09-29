using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int printedLines = 0;
            int symbols = 0;

            string values = "";

            int[] arrayOne = new int[printedLines + 1];
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = 1;
                Console.WriteLine(arrayOne[i]);
                printedLines++;
            }
            int [] exhibitionArray = new int[lines];
            while (printedLines != lines)
            {
                    symbols = 0;
                    
                    int[] arrayTwo = new int[printedLines + 1];
                    int[] arrayThree = new int[printedLines + 2];

                for (int i = 0; i < arrayTwo.Length; i++)
                  {
                    if (printedLines == 1)
                    {
                        if (i == 0)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                            continue;
                        }

                        else if (i == arrayTwo.Length - 1)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                        }
                    }
                    else if (printedLines > 1 && printedLines < 3)
                    {
                        if (i == 0)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                            continue;
                        }

                        else if (i == arrayTwo.Length)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                        }
                        else
                        {

                            arrayTwo[i] = arrayThree[i] + arrayThree[i - 1];
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                        }
                    }



                    else
                    {
                        if (i == 0)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                            continue;
                        }

                        else if (i == arrayTwo.Length)
                        {
                            arrayTwo[i] = 1;
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                        }
                        else
                        {

                            arrayTwo[i] = exhibitionArray[i] + exhibitionArray[i - 1];
                            Console.Write($"{arrayTwo[i]} ");
                            symbols++;
                        }
                    }
                    
                    if (symbols == arrayTwo.Length)
                    {
                        Console.WriteLine();
                        printedLines++;

                    }
                    if (printedLines == lines)
                    {
                        break;

                    }
                }
                  symbols = 0;

                if (printedLines == lines)
                {
                    break;

                }
                for (int i = 0; i < arrayThree.Length; i++)
                {
                    if (i == 0)
                    {
                        arrayThree[i] = 1;
                        Console.Write($"{arrayThree[i]} ");
                        symbols++; ;
                    }

                    else if (i == arrayTwo.Length)
                    {
                        arrayThree[i] = 1;
                        Console.Write($"{arrayThree[i]} ");
                        symbols++;
                    }
                    else
                    {
                        arrayThree[i] = arrayTwo[i] + arrayTwo[i - 1];
                        Console.Write($"{arrayThree[i]} ");
                        symbols++;
                    }
                    if (symbols == arrayThree.Length)
                    {
                        Console.WriteLine();
                        printedLines++;

                    }
                    if (printedLines == lines)
                    {
                        break;

                    }

                    for (int q = 0; q < arrayThree.Length; q++)
                    {
                        exhibitionArray[q] = arrayThree[q];
                    }
                }
                
            }
        }
    }
}

