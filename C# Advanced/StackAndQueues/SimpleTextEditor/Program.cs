using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int numberOfLines = int.Parse(Console.ReadLine());
            Stack<string> undoList = new Stack<string>();

            for (
                int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" ");
                if (int.Parse(parts[0]) == 1)
                {
                    undoList.Push(command);
                    command += parts[1];
                    undoList.Push(parts[1]);
                    
                }

                if (int.Parse(parts[0]) == 2)
                {
                    undoList.Push(command);
                    string text = command.Substring(command.Length - int.Parse(parts[1]));
                    command = command.Remove(command.Length - int.Parse(parts[1]));
                    undoList.Push(text);
                }

                if (int.Parse(parts[0]) == 3)
                {
                    int from = int.Parse(parts[1].ToString());
                    string c  = command[from - 1].ToString();
                    Console.WriteLine(c);
                }

                if (int.Parse(parts[0]) == 4)
                {
                    undoList.Pop();
                    command = undoList.Peek();
                    undoList.Pop();
                    
                }
            }
           
        }
    }
}
