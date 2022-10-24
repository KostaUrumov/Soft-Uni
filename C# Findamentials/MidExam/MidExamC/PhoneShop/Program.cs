using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = new List<string>();
            string[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < line.Length; i++)
            {
                phones.Add(line[i]);

            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] commandParts = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (commandParts[0] == "Add")
                {
                    if (phones.Contains(commandParts[1]))
                    {
                        continue;
                    }
                    phones.Add(commandParts[1]);
                    
                }
                if (commandParts[0] == "Remove")
                {
                    if (phones.Contains(commandParts[1]))
                    {
                        phones.Remove(commandParts[1]);
                    }

                }
                if (commandParts[0] == "Bonus phone")
                {
                    string[] newPhones = commandParts[1]
                        .Split(":");

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == newPhones[0])
                        {
                            phones.Insert(i + 1, newPhones[1]);
                        }

                    }

                }
                if (commandParts[0] == "Last")
                {
                    if (phones.Contains(commandParts[1]))
                    {
                        phones.Remove(commandParts[1]);
                        phones.Add(commandParts[1]);
                    }


                }

            }

            Console.WriteLine(String.Join(", ",phones));


        }
    }
}
