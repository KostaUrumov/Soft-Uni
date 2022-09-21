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
            int numbersOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] endocedLineInNumbers = new int[numbersOfLines];

            for (int i = 0; i < numbersOfLines; i++)
            {
                string lineToUse = Console.ReadLine();
                sum = 0;



                for (int j = 0; j < lineToUse.Length; j++)
                {
                    char c = lineToUse[j];
                    bool isTrue = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
                    bool isTrueCapital = (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');

                    if (isTrue == true)
                    {
                        sum += c * lineToUse.Length;
                        
                    }

                    if (isTrueCapital == true)
                    {
                        sum += c * lineToUse.Length;
                        
                    }

                    else if (isTrue == false && isTrueCapital == false)
                    {
                        sum += c / lineToUse.Length;
                    }


                    if (j == lineToUse.Length - 1)
                    {
                        for (int k = i; k == i; k++)
                        {
                            endocedLineInNumbers[k] = sum;
                        }
                    }
                }
                
            }
            int greatestNumber = 0;
            int without = int.MaxValue;
            int timesDone = 0;
            int[] ascendingNumbers = new int[endocedLineInNumbers.Length];
            while (timesDone != endocedLineInNumbers.Length)
            {

                for (int i = 0; i < endocedLineInNumbers.Length; i++)
                {
                    if (endocedLineInNumbers[i] > greatestNumber)
                    {
                        greatestNumber = endocedLineInNumbers[i];
                        without = i;
                    }

                }
                endocedLineInNumbers[without] = 0;
                timesDone++;
                
                for (int r = timesDone - 1; r == timesDone - 1; r++)
                {
                    ascendingNumbers[r] = greatestNumber;
                }
                greatestNumber = 0;

            }
            for (int i = ascendingNumbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ascendingNumbers[i]);
            }
        }
        
    }
}


