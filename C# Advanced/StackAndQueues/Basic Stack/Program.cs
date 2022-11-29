using System;
using System.Collections;
using System.Collections.Generic;

namespace StacksandQueuesExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] positions = command.Split(' ');
            int toPush = int.Parse(positions[0]);
            int toPop = int.Parse(positions[1]);
            int toCheck = int.Parse(positions[2]);

            string numbers = Console.ReadLine();
            string[] realNumbers = numbers.Split(" ");

            Stack<int> theStack = new Stack<int>();
            for (int i = 0; i < toPush; i++)
            {
                theStack.Push(int.Parse(realNumbers[i]));
            }

            for (int i = 0; i < toPop; i++)
            {
                theStack.Pop();
            }

            if (theStack.Count == 0)
            {
                Console.WriteLine(0);
            }

            if (theStack.Contains(toCheck))
            {
                Console.WriteLine("true");
            }
            if (!theStack.Contains(toCheck) && theStack.Count > 0)
            {
               List<int> sorted = new List<int>(theStack);
                sorted.Sort();
                Console.WriteLine(sorted[0]);
            }

        }
    }
}
