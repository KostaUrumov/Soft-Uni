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
            string [] textToUse = Console.ReadLine().Split(' ');
            int [] numbersToUe = new int[textToUse.Length];

            for (int i = 0; i < textToUse.Length; i++)
            {
                numbersToUe[i] = int.Parse(textToUse[i]);
            }

            int integerToUse = 0;
            int count = 0;
            int sumLeft = 0;
            int sumRight = 0;
            int index = 0;

            for (int i = 0; i < numbersToUe.Length; i++)
            {
                count++;
                sumRight = 0;
                sumLeft = 0;
                integerToUse = numbersToUe[i];


                for (int j = 0; j < count - 1; j++)
                {
                    sumLeft += numbersToUe[j];
                }



                for (int h = count; h < numbersToUe.Length; h++)
                {
                    sumRight += numbersToUe[h];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i == numbersToUe.Length - 1)
                {
                    Console.WriteLine("no");
                }
            }
                

        }
    }
}


