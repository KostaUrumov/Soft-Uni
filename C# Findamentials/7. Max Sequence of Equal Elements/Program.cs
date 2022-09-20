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
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int biggestSequence = 0;
            int currentNumberSequence = 0;
            int neededIndex = 0;
            int indexToStart = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int numberUse = numbersArray[i];
                currentNumberSequence = 0;
                for (int k = i + 1; k < numbersArray.Length; k++)
                {
                    if (numberUse == numbersArray[k])
                    {
                        currentNumberSequence++;
                        continue;

                    }
                    else
                    {
                        break;
                    }
                }

                if (currentNumberSequence > biggestSequence)
                {   
                    indexToStart = i;
                    biggestSequence = currentNumberSequence;
                }
            }
        

            for (int i = indexToStart ; i <= indexToStart+ biggestSequence; i++)
            {
                Console.Write($"{numbersArray[i]} ");
            }

        }
    }
}


