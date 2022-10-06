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
            int number = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());


            for (int i = number; i <= final; i++)
            {
                char toPrint = (char)i;
                Console.Write($"{toPrint} ");
            }

        }

    }
}