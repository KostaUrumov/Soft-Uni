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
            string[] line = Console.ReadLine().Split();
            int [] numbersArray = new int[line.Length];
            


            for (int k = 0; k < numbersArray.Length; k++)
            {
               int toAdd = int.Parse(line[k]);
                numbersArray[k] = toAdd;
            }

            int numberToUse = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numberToUse = numbersArray[i];
                int count = 0;

                if (i == numbersArray.Length - 1)
                {
                    Console.Write(numbersArray[i]);
                }

                for (int k = i + 1 ; k < numbersArray.Length; k++)
                {

                    
                    if (numberToUse > numbersArray[k])
                    {
                        count++;
                        if (count == numbersArray.Length - i - 1)
                        {
                            Console.Write($"{numbersArray[i]} ");
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }


                }


            }


        }
    }
}


