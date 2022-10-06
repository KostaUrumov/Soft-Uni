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
            int numberOfTries = int.Parse(Console.ReadLine());
            int letersFilled = 0;

            for (int i = 0; i < numberOfTries; i++)
            {
                int fillingTry = int.Parse(Console.ReadLine());
                letersFilled += fillingTry;
                if (letersFilled > 255)
                {
                    letersFilled -= fillingTry;
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(letersFilled);
       

        }

    }
}

