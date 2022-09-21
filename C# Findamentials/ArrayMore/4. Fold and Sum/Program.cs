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
            string integers =  Console.ReadLine();
            string [] line = integers.Split(' ');
            int [] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            int lengthOfIntegers = numbers.Length /2;

            int []newLineNumbers = new int[lengthOfIntegers];
            int []newLineNumbersTwo = new int[lengthOfIntegers];
            int indexToUse = 0;
            int done = 0;

            for (int i = 0; i < newLineNumbers.Length; i++)
            {
                newLineNumbers[i] = numbers[lengthOfIntegers / 2 + i];
                indexToUse = i;
            }

            for (int i = lengthOfIntegers + lengthOfIntegers /2 ; i < numbers .Length ; i++)
            {
                newLineNumbersTwo[newLineNumbersTwo.Length - 1 - done] = numbers[i];
                done++;
            }

            done = 0;
            for (int i = 0; i < lengthOfIntegers /2 ; i++)  
            {
                newLineNumbersTwo[lengthOfIntegers / 2 -1 - done] = numbers[i];
                done++;
            }


           

            for (int i = 0; i < lengthOfIntegers; i++)
            {
                Console.Write($"{newLineNumbers[i] + newLineNumbersTwo[i]} ");
            }



            



        }

    }
}

