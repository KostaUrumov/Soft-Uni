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
            string [] newLine = Console.ReadLine().Split(' ');
            string [] toCompare = Console.ReadLine().Split(' ');


            for (int i = 0; i < newLine.Length; i++)
            {
                for (int j = 0; j < toCompare.Length; j++)
                {
                    if (toCompare[j] == newLine[i])
                    {
                        Console.Write($"{toCompare[j]} ");
                    }
                }
            }

        }
    }
}


