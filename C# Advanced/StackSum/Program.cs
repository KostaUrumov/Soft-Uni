using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Stack<int> integers = new Stack<int>(line.Split(" ").Select(int.Parse).ToArray());

            string command = Console.ReadLine();
            command = command.ToLower();

            while (command != "end")
            {
                string[] commandParts = command.Split(" ");

                if (commandParts[0] == "remove")
                {
                    if (int.Parse(commandParts[1]) < integers.Count)
                    {
                        for (int i = 0; i < int.Parse(commandParts[1]); i++)
                        {
                            integers.Pop();
                        }
                    }
                }

                if (commandParts[0] == "add")
                {
                    integers.Push(int.Parse(commandParts[1]));
                    integers.Push(int.Parse(commandParts[2]));
                }
                command = Console.ReadLine();
                command = command.ToLower();
            }

            Console.WriteLine($"Sum: {integers.Sum()}");
        }
    }
}
