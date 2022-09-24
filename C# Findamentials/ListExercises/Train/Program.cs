using System;
using System.Collections.Generic;

namespace ListsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string lineWithWagons = Console.ReadLine(); 
           string [] lineWagons = lineWithWagons.Split(' ');
           List<int> passengerPerWagon = new List<int>(lineWagons.Length);
            for (int i = 0; i < lineWagons.Length; i++)
            {
                passengerPerWagon.Add(int.Parse(lineWagons[i]));
                
            }

            int maxCapacityPerWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine(String.Join(" ", passengerPerWagon));
                    
                    break;
                }

                string[] commandLine = command.Split(" ");

                if (commandLine[0] == "Add")
                {

                    passengerPerWagon.Add(int.Parse(commandLine[1]));
 
                }

                else if (commandLine[0] != "Add")
                {
                    int passengersToAdd = int.Parse(commandLine[0]);
                    for (int i = 0; i < passengerPerWagon.Count; i++)
                    {
                     int total = passengerPerWagon[i] + passengersToAdd;
                        if (total > maxCapacityPerWagon)
                        {
                            continue;
                        }
                        else
                        {
                            passengerPerWagon[i] = total;
                            break;
                        }
                    }
                }

            }

        }
    }
}
