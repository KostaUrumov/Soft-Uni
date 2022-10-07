using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playerLocations = new Dictionary<string, List<string>>();
            Dictionary<string, List<int>> playerStats = new Dictionary<string, List<int>> ();

            while (true)
            {
                string mobaLine = Console.ReadLine();
                int printed = 0;
                if (mobaLine == "Season end")
                {
                    break;
                }
                string[] moba = mobaLine
                    .Split(' ');
                if (moba[1] == "vs")
                {
                    
                    if (!playerLocations.ContainsKey(moba[0]))
                    {
                        
                        continue;
                    }
                    if (!playerLocations.ContainsKey(moba[2]))
                     {
                        
                        continue;
                    }


                    if (playerLocations.ContainsKey(moba[0]) && playerLocations.ContainsKey(moba[2]))
                    {
                       
                        foreach (string location in playerLocations[moba[2]])
                        {
                            if (playerLocations[moba[0]].Contains(location))
                            {
                                int number = 0;
                                int straight = 0;
                                for (int i = 0; i < playerLocations[moba[0]].Count; i++)
                                {
                                    if (playerLocations[moba[0]][i] == location)
                                    {
                                        number = i;
                                        break;
                                    }
                                }
                                for (int i = 0; i < playerLocations[moba[0]].Count; i++)
                                {
                                    if (playerLocations[moba[2]][i] == location)
                                    {
                                        straight = i;
                                        break;
                                    }
                                }

                                if (playerStats[moba[2]][straight] > playerStats[moba[0]][number])
                                {
                                   
                                    playerLocations.Remove(moba[0]);
                                    playerStats.Remove(moba[0]);
                                    printed++;
                                    continue;
                                }
                                if (playerStats[moba[2]][straight] < playerStats[moba[0]][number])
                                {
                                    
                                    playerLocations.Remove(moba[2]);
                                    playerStats.Remove(moba[2]);
                                    printed++;
                                    continue;
                                }
                                if (printed > 0)
                                {
                                    continue;
                                }
                            }
                            if (printed > 0)
                            {
                                continue;
                            }
                        }
                        if (printed > 0)
                        {
                            continue;
                        }
                    }
                    if (printed > 0)
                    {
                        continue;
                    }

                    if (!playerLocations.ContainsKey(moba[0]) || playerLocations.ContainsKey(moba[2]))
                   {
                        
                        continue;
                   }

                    if (printed > 0)
                    {
                        continue;
                    }

                }

                
                string[] playerProps = mobaLine
                    .Split(" -> ")
                    .ToArray();


                if (playerLocations.ContainsKey(playerProps[0]))
                {
                    int indexToUse = 0;
                    if (playerLocations[playerProps[0]].Contains(playerProps[1]))
                    {
                        for (int i = 0; i < playerLocations[playerProps[0]].Count; i++)
                        {
                            if (playerLocations[playerProps[0]][i] == playerProps[1])
                            {
                                indexToUse = i;
                                break;
                            }

                        }

                        if (playerStats[playerProps[0]][indexToUse] < int.Parse(playerProps[2]))
                        {
                            playerStats[playerProps[0]][indexToUse] = int.Parse(playerProps[2]);
                        }
                    }

                    if (!playerLocations[playerProps[0]].Contains(playerProps[1]))
                    {
                        playerLocations[playerProps[0]].Add(playerProps[1]);
                        playerStats[playerProps[0]].Add(int.Parse(playerProps[2]));
                    }
                    
                }

                if (!playerLocations.ContainsKey(playerProps[0]))
                {
                    playerLocations.Add(playerProps[0], new List<string>());
                    playerLocations[playerProps[0]].Add(playerProps[1]);
                    playerStats.Add(playerProps[0], new List<int>());
                    playerStats[playerProps[0]].Add(int.Parse(playerProps[2]));
                }

                
            }

            Dictionary <string, int> byTotalPoints = new Dictionary<string, int>();


            foreach (var playerProps in playerLocations.Keys)
            {
                
                int total = 0;
                if (playerLocations[playerProps].Count > 1)
                {
                   
                    foreach (var player in playerStats.Keys)
                    {

                        if (player == playerProps)
                        {
                            for (int i = 0; i < playerStats[playerProps].Count; i++)
                            {
                                total += playerStats[playerProps][i];

                                if (i == playerStats[playerProps].Count - 1)
                                {
                                    byTotalPoints.Add(playerProps, total);
                                }
                                
                            }
                        }
                    }

                }
                if (total == 0)
                {
                    byTotalPoints.Add(playerProps, playerStats[playerProps][0]);
                }
                
            }

            Dictionary<string, int> byPoints = new Dictionary<string, int>(); 
            foreach (var player in byTotalPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var playerProps in playerStats.Keys)
                {
                    if (playerProps == player.Key)
                    {
                        if (playerStats[playerProps].Count == 1)
                        {
                            foreach (var goji in playerStats[playerProps])
                            {
                                Console.WriteLine($"- {playerLocations[playerProps][0]} <::> {playerStats[playerProps][0]}");
                            }
                        }
                        if (playerStats[playerProps].Count > 1)
                        {
                            int numbercho = 0;
                            foreach (var furior in playerStats[playerProps])
                            {
                                byPoints.Add(playerLocations[playerProps][numbercho], furior);
                                numbercho++;
                            }


                            foreach (var goji in byPoints.OrderByDescending(x => x.Value))
                            {
                                Console.WriteLine($"- {goji.Key} <::> {goji.Value}");
                            }
                        }
                    }

                }
            }
            
        }
    }
}
