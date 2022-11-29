using System;
using System.Collections.Generic;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> result = new Stack<int>();
            string command = Console.ReadLine();
            string [] parts = command.Split(" ");
            result.Push(int.Parse(parts[0]));
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[i] == "+")
                {
                    result.Push(int.Parse(parts[i + 1]) + result.Pop());
                }

                if (parts[i] == "-")
                {
                    result.Push(result.Pop() - int.Parse(parts[i + 1]));
                }

            }

            Console.WriteLine(result.Pop());
        }
    }
}
