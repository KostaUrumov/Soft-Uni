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
            int startSpiceNumber = int.Parse(Console.ReadLine());
            int day = 0;
            int consume = 0;
            int earned = 0;
            int storage = 0;


            while (startSpiceNumber >= 100)
            {
                earned += startSpiceNumber;
                startSpiceNumber -= 10;
                storage = earned - consume;
                if (storage < 26)
                {
                    consume += storage;
                }
                else
                {
                    consume += 26;
                }

                day++;
            }

            earned = earned - consume - 26;
            if (storage < earned)
            {
                earned = earned + 26;
                earned = storage - consume;
            }

            Console.WriteLine(day);
            Console.WriteLine(earned);
        }

    }
}


