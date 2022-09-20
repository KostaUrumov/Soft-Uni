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
           string [] line = Console.ReadLine().Split(' ');
           int coefficient = int.Parse(Console.ReadLine());
            string [] reverseLine = new string[line.Length];


            for (int i = 0; i < line.Length; i++)
            {
                int numberTouse = i + coefficient;
                if (coefficient > line.Length)
                {
                   numberTouse = coefficient - line.Length +i;
                    if (numberTouse >= line.Length)
                    {
                        numberTouse = numberTouse - line.Length;
                        reverseLine[i] = line[numberTouse];
                        Console.Write($"{reverseLine[i]} ");
                        continue;
                    }
                    reverseLine[i] = line[numberTouse];
                    Console.Write($"{reverseLine[i]} ");
                    continue;
                }

                if (numberTouse >= line.Length)
                {
                    numberTouse = numberTouse - line.Length;
                    reverseLine[i] = line[numberTouse];
                    Console.Write($"{reverseLine[i]} ");
                }


                else
                {
                   reverseLine[i] = line[numberTouse];
                   Console.Write($"{reverseLine[i]} ");
                }
                
                
                
            }


           

        }
    }
}


