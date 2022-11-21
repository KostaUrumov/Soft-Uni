using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>();
            string commandSongs = Console.ReadLine();
            string[] values = commandSongs.Split(", ");
            for (int i = 0; i < values.Length; i++)
            {
                songs.Enqueue(values[i]);
            }
            int done = 0;
            int needed = 0;
            
            while (songs.Count > 0)
            {
                string com = string.Empty;
                string command = Console.ReadLine();
                string leid = string.Empty;
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 32)
                    {
                        needed = i;
                        break;
                    }
                    com+= command[i];
                }

                leid = command.Substring(needed+1);
                
                if (com == "Add")
                {
                    if (songs.Contains(leid))
                    {
                        Console.WriteLine($"{leid} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(leid);
                    }
                }

                if (com == "Play")
                {
                    songs.Dequeue();
                }
                
                if (com == "Show")
                {  
                    List<string> list = new List<string>(songs);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == list.Count - 1)
                        {
                            Console.Write($"{list[i]}");
                            continue;
                        }
                        Console.Write($"{list[i]}, ");
                        done ++;
                    }
                    Console.WriteLine();
                }
            }
            
            Console.Write("No more songs!");
            
        }
    }
}
