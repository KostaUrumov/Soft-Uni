using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EnergyDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCaffein = 0;
            int[] commandOne = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] commandTwo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> drinks = new Queue<int>();
            Stack<int> caffein = new Stack<int>();
            for (int i = 0; i < commandOne.Length; i++)
            {
                caffein.Push(commandOne[i]);
            }

            for (int i = 0; i < commandTwo.Length; i++)
            {
                drinks.Enqueue(commandTwo[i]);
            }


            while (true)
            {
                if (drinks.Count == 0)
                {
                    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
                    Console.WriteLine($"Stamat is going to sleep with {totalCaffein} mg caffeine.");
                    break;
                }

                if (caffein.Count == 0)
                {
                    Console.Write("Drinks left: ");
                    Console.WriteLine(String.Join(", ", drinks));
                    Console.WriteLine($"Stamat is going to sleep with {totalCaffein} mg caffeine.");
                    break;
                }
                int num = caffein.Peek();
                int nu = drinks.Peek();

                int result = num * nu;


                if (result + totalCaffein <= 300)
                {
                    totalCaffein += result;
                    caffein.Pop();
                    drinks.Dequeue();
                    continue;
                }
                if (result + totalCaffein > 300)
                {
                    if (totalCaffein - 30 < 0)
                    {
                        totalCaffein = 0;
                        caffein.Pop();
                        drinks.Enqueue(drinks.Peek());
                        drinks.Dequeue();
                        continue;

                    }
                    totalCaffein -= 30;

                    caffein.Pop();
                    drinks.Enqueue(drinks.Peek());
                    drinks.Dequeue();
                }
            }


        }
    }
}
