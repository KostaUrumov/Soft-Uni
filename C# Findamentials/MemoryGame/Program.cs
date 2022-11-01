using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> theList = new List<string>();
            int move = 0;

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int c = 0; c < command.Length; c++)
            {
                theList.Add(command[c].ToString());
            }

            while (true)
            {
                if (theList.Count == 0)
                {
                    break;
                }
                string commandLine = Console.ReadLine();
                move++; 
                if (commandLine == "end")
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(String.Join(" ",theList));
                    break;
                }

                int[] parts = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (parts[0] < 0 || parts[0] >= theList.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    theList.Insert(theList.Count/2, $"-{move}a");
                    theList.Insert(theList.Count/2, $"-{move}a");
                    continue;
                }

                if (parts[1] < 0 || parts[1] >= theList.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    theList.Insert(theList.Count/2, $"-{move}a");
                    theList.Insert(theList.Count/2, $"-{move}a");
                    continue;
                }

                if (theList[parts[0]] == theList[parts[1]])
                {
                    
                    Console.WriteLine($"Congrats! You have found matching elements - {theList[parts[0]]}!");
                    theList.RemoveAt(parts[0]);
                    if (parts[1] != 0)
                    theList.RemoveAt(parts[1]-1);
                    else
                    {
                        theList.RemoveAt(parts[1]);
                    }
                    if (theList.Count == 0)
                    {
                        Console.WriteLine($"You have won in {move} turns!");
                        break;
                    }
                    continue;
                }

                if(theList[parts[0]] != theList[parts[1]])
                {
                    
                    Console.WriteLine($"Try again!");
                    continue;
                }

               

                if (parts[0] == parts[1])
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    theList.Insert(theList.Count /2, $"-{move}a");
                    theList.Insert(theList.Count /2, $"-{move}a");
                    continue;
                }

                
                

            }
        }
    }
}
