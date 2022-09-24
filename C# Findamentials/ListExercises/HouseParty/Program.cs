using System;
using System.Collections.Generic;

namespace _3._HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPotentialGuests = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();


            for (int i = 0; i < numberOfPotentialGuests; i++)
            {
                int count = 0;
                string potentialGuests = Console.ReadLine();
                string [] gointOrNot = potentialGuests.Split(' ');

                for (int j = 0; j < guestList.Count; j++)
                {
                    if (guestList[j] == gointOrNot[0] && gointOrNot [2] != "not")
                    {
                        count++;
                        Console.WriteLine($"{gointOrNot[0]} is already in the list!");
                        break;
                    }
                }

                if (count > 0)
                {
                    continue;
                }

                if (gointOrNot[2] != "not")
                {
                    guestList.Add(gointOrNot[0]);
                }

                if (gointOrNot[2] == "not")
                {
                  if (guestList.Contains(gointOrNot[0]))
                  {
                   guestList.Remove(gointOrNot[0]);
                   }
                  else
                  {
                   Console.WriteLine(($"{gointOrNot[0]} is not in the list!"));
                  }

                    
                    
                }

            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);

            }

        }
    }
}
