using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> shoppingLine  = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command != "Paid" && command != "End")
                {
                    shoppingLine.Enqueue(command);
                }
                if (command == "Paid")
                {
                    while (shoppingLine.Count > 0)
                    {
                        Console.WriteLine(shoppingLine.Dequeue());
                    }
                }

                if (command == "End")
                {
                    Console.WriteLine($"{shoppingLine.Count} people remaining.");
                    break;
                }
            }
        }
    }
}
