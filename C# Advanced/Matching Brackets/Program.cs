using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            List<string> answers = new List<string>();
            string command = Console.ReadLine();
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 40)
                {
                    stack.Push(i);
                }
                if (command[i] == 41)
                {
                    int number = stack.Pop();
                    string subs = command.Substring(number, i - number+1);
                    answers.Add(subs);

                }
            }
            foreach (string s in answers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
