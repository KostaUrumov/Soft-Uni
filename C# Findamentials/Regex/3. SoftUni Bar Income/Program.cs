using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex name  = new Regex(@"[%][A-Z][a-z]*[%]");
            Regex product = new Regex(@"[<][A-Z][a-z]*[>]");
            Regex amount = new Regex(@"[|][0-9]+[|]");
            Regex value = new Regex(@"[1-9].[.]*[0-9]*[$]");
            string zaglavie = "";
            string prod = "";
            string kolko = "";
            string pari = "";

            double price = 0;


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of shift")
                {
                    Console.WriteLine($"Total income: {price, 0:f2}");
                    break;
                }

                MatchCollection matches = name.Matches(command);
                if (matches.Count > 0)
                {
                    zaglavie = matches[0].Value;
                    zaglavie = zaglavie.Remove(0, 1);
                    zaglavie = zaglavie.Remove(zaglavie.Length - 1, 1);
                    MatchCollection matches2 = product.Matches(command);
                    if (matches2.Count > 0)
                    {
                       prod = matches2[0].Value;
                       prod = prod.Remove(0, 1);
                       prod = prod.Remove(prod.Length - 1, 1);
                       
                        MatchCollection match3 = amount.Matches(command);
                        if (match3.Count > 0)
                        {
                            kolko = match3[0].Value;
                            kolko = kolko.Remove(0, 1);
                            kolko = kolko.Remove(kolko.Length - 1, 1);

                            MatchCollection match4 = value.Matches(command);
                            if (match4.Count > 0)
                            {
                                pari = match4[0].Value;
                                pari = pari.Remove(pari.Length - 1, 1);
                                double goooo = double.Parse(kolko) * double.Parse(pari);
                                price += goooo;
                                Console.WriteLine($"{zaglavie}: {prod} - {goooo, 0:f2}");
                            }
                        }
                    }
                }


            }
        }
    }
}
