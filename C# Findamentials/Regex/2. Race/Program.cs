using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            Dictionary<string, int> peoplesData = new Dictionary<string, int>();

            string[] people = names
                .Split(",");

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = people[i].Trim();
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of race")
                {
                    break;
                }
                string name = string.Empty;
                int distance = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] >= 65 && command[i] <= 90)
                    {
                        name += command[i];
                    }

                    if (command[i] >= 97 && command[i] <= 122)
                    {
                        name+= command[i].ToString();
                    }
                }

                for (int i = 0; i < people.Length; i++)
                {
                    if (name == people[i])
                    {
                        for (int o = 0; o < command.Length; o++)
                        {
                            if (command[o] >= 49 && command[o] <= 57)
                            {
                                distance += int.Parse(command[o].ToString());
                            }
                        }
                    }
                }

                if (peoplesData.ContainsKey(name))
                {
                    peoplesData[name] += distance;
                    continue;
                }
                else if (!peoplesData.ContainsKey(name))
                {
                    for (int i = 0; i < people.Length; i++)
                    {
                        if (name == people[i])
                        {
                            peoplesData.Add(name, distance);
                            break;
                        }
                    }
                }
                
            }

            var ordered = peoplesData.OrderBy(x=>x.Value).ToDictionary(x => x.Key, x => x.Value);
            ordered = ordered.Reverse().ToDictionary(x => x.Key, x => x.Value);

            int places = 0;
            foreach (var item in ordered.Keys)
            {
                places++;
                if (places == 1)
                {
                    Console.WriteLine($"1st place: {item}");
                    continue;
                }
                if (places == 2)
                {
                    Console.WriteLine($"2nd place: {item}");
                    continue;
                }
                if (places == 3)
                {
                    Console.WriteLine($"3rd place: {item}");
                    break;
                }

            }

        }

    }
}
