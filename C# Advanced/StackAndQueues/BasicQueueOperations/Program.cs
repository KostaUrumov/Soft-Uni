using System;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string numbers = Console.ReadLine();

            string [] commandParts = command.Split(" ");
            string[] numbersParts = numbers.Split(" ");
            int toAdd = int.Parse(commandParts[0]);
            int toRemove = int.Parse(commandParts[1]);
            int toCheck = int.Parse(commandParts[2]);

            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < toAdd; i++)
            {
                nums.Enqueue(int.Parse(numbersParts[i]));
            }

            for (int i = 0; i < toRemove; i++)
            {
                nums.Dequeue();
            }

            if (nums.Contains(toCheck))
            {
                Console.WriteLine("true");
            }

            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (!nums.Contains(toCheck) && nums.Count >0)
            {
                List<int> ordered = new List<int>(nums);
                ordered.Sort();
                Console.WriteLine(ordered[0]);
            }
        }
    }
}
