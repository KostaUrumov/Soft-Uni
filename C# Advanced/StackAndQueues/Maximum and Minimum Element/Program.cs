using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(' ');
                if (int.Parse(parts[0]) == 1)
                {
                    stack.Push(int.Parse(parts[1]));
                }
                if (int.Parse(parts[0]) == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }

                if (int.Parse(parts[0]) == 3)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }

                    else
                    {
                        List<int> list = new List<int>(stack);
                        Console.WriteLine(list.Max());
                    }


                }
                if (int.Parse(parts[0]) == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        List<int> list = new List<int>(stack);
                        Console.WriteLine(list.Min());
                    }
                }

            }
                while (stack.Count > 0)
                {
                    if (stack.Count == 1)
                    {
                        Console.Write($"{stack.Pop()}");
                        continue;    

                    }
                    Console.Write($"{stack.Pop()}, ");
                }
        }
    }
}
