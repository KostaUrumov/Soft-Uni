using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex symbols = new Regex(@"[SsTtAaRr]+");
            int numberOfLines = int.Parse(Console.ReadLine());

            List<string> destroyed = new List<string>();
            List<string> attacked = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string command = Console.ReadLine();
                string empty = string.Empty;
                string password  = string.Empty;
                
                MatchCollection matches = symbols.Matches(command);
                foreach (Match match in matches)
                {
                    empty += match.Value;
                }

                int sustract = empty.Length;

                for (int k = 0; k < command.Length; k++)
                {
                    char c = command[k];
                    int toRemove = (c - sustract);
                    char toAdd = (char)toRemove;
                    password += toAdd;
                }

                Regex planet = new Regex(@"[@]{1}([A-Z]*[a-z]*)");
                Regex popilation = new Regex(@"[:]{1}([0-9]+)");
                Regex attackType = new Regex(@"[!]{1}([A]*[D]*)[!]{1}");
                Regex soldier = new Regex(@"[-]*[>]{1}([0-9]+)");

                MatchCollection planets = planet.Matches(password);
                if (planets.Count > 0)
                {
                password = password.Remove(planets[0].Index, planets[0].Length);    
                }
                MatchCollection people = popilation.Matches(password);
                if (people.Count > 0)
                {
                password = password.Remove(people[0].Index, people[0].Length);   
                }
                MatchCollection attacs = attackType.Matches(password);
                if (attacs.Count > 0)
                {
                password = password.Remove(attacs[0].Index, attacs[0].Length);
                }
                MatchCollection army = soldier.Matches(password);
                if (army.Count > 0)
                {
                password = password.Remove(army[0].Index, army[0].Length);
                }
                Regex doNootNeed = new Regex(@"[-]*[@]*[!]*[:]*[>]");
                MatchCollection needless = doNootNeed.Matches(password);
                if (needless.Count > 0)
                {
                    continue;
                }

                if (planets.Count > 0)
                {
                    if (people.Count > 0)
                    {
                        if (attacs.Count > 0)
                        {
                            if (army.Count > 0)
                            {
                                if (attacs[0].Groups[1].ToString() == "D")
                                {
                                    destroyed.Add(planets[0].Groups[1].ToString());
                                }
                                if (attacs[0].Groups[1].ToString() == "A")
                                {
                                    attacked.Add(planets[0].Groups[1].ToString());
                                }
                            }
                        }
                    }
                }

            }

            destroyed.Sort();
            attacked.Sort();
            

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var planeeee in attacked)
            {
                Console.WriteLine($"-> {planeeee}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var gop in destroyed)
            {
                Console.WriteLine($"-> {gop}");
            }

        }
    }
}
