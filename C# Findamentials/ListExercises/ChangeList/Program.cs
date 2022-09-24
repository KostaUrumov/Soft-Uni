using System;
using System.Collections.Generic;


namespace _2.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineOfIntegers = Console.ReadLine();
            string [] intLine = lineOfIntegers.Split(' ');
            List<int> numbersValue = new List<int>(intLine.Length);

            for (int i = 0; i < intLine.Length; i++)
            {
                numbersValue.Add(int.Parse(intLine[i]));
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine(String.Join(" ", numbersValue));
                    break;
                }

                string[] commandLine = command.Split(' ');
                if (commandLine[0] == "Delete")
                {
                    for (int i = 0; i < numbersValue.Count; i++)
                    {
                        if (numbersValue[i] == int.Parse(commandLine[1]))
                        {
                            numbersValue.RemoveAt(i);
                            i--;
                        }
                    }
                }

                if (commandLine[0] == "Insert")
                {
                    int position = int.Parse(commandLine[2]);
                    int value = int.Parse(commandLine[1]);
                    numbersValue.Insert(position, value);
                }

            }
        }
    }
}
