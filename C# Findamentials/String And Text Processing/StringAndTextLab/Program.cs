using System;
using System.Collections.Generic;

namespace StringAndTextLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }
                List<char> reversedCommand = new List<char>();
                for (int i = command.Length-1; i >= 0; i--)
                {
                    reversedCommand.Add(command[i]);
                }

                string [] reverse = new string [reversedCommand.Count];
                for (int i = 0; i < reversedCommand.Count; i++)
                {
                    reverse[i] = reversedCommand[i].ToString();
                }

                Console.Write($"{command} = ");
                Console.Write(String.Join("", reverse));
                Console.WriteLine();
            }
        }
    }
}
