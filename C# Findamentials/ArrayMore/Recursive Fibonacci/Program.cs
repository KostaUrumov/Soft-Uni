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
            int numberToGet = int.Parse(Console.ReadLine());

            int [] fibonacciArray = new int[numberToGet];
            for (int i = 0; i < fibonacciArray.Length; i++)
            {
                if (i < 2)
                {
                    fibonacciArray[i] = 1;
                }

                else
                {
                    fibonacciArray [i] = fibonacciArray [i-1] + fibonacciArray[i - 2];
                }

            }

            Console.WriteLine(fibonacciArray[numberToGet - 1]);
        }
    }
}

