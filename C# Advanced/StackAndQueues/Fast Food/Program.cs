using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>();
            string command = Console.ReadLine();
            string[] parts = command.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                orders.Enqueue(int.Parse(parts[i]));
            }
            List<int> biggestOrder = new List<int>(orders);
            Console.WriteLine(biggestOrder.Max());
            while (orders.Count > 0)
            {
                if (value - orders.Peek() < 0)
                {
                    break;
                }

                else
                {
                    value -= orders.Dequeue();
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                while (orders.Count > 0)
                {
                    if (orders.Count == 1)
                    {
                        Console.Write($"Orders left: {orders.Dequeue()}");
                        continue;
                    }
                    else
                    {
                        Console.Write($"Orders left: {orders.Dequeue()} ");
                    }
                    
                }
            }
        }
    }
}
