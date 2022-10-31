using System;
using RegexEx;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace RegexEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex purchase = new Regex(@"[>]{2}[A-Z]*[a-z]*[<]{2}\b");
            double totalPrice = 0;
            Regex moneySeparator = new Regex(@"[0-9]+[.]+[0-9]*");
            
            List<string> furniture = new List<string>();
            while (true)
            {
                string fur = string.Empty;
                double price = 0;
                int amount = 0;
                
                string commandLine = Console.ReadLine();
                if (commandLine == "Purchase")
                {
                    break;
                }

                MatchCollection matchCollection = purchase.Matches(commandLine);
                if (matchCollection.Count == 0)
                {
                    continue;
                }

                fur = matchCollection[0].Value.Replace("<<","");
                fur = fur.Replace(">>", "");
                
                furniture.Add(fur);
                if (matchCollection.Count > 0)
                {
                    MatchCollection geld = moneySeparator.Matches(commandLine);
                    int strart = commandLine.IndexOf("<");
                    int end = commandLine.IndexOf('!');
                    int length = end - (strart+2);
                    int amountStart = commandLine.IndexOf("!");
                    int amountEnd = commandLine.Length- amountStart - 1;
                    double spend = double.Parse(commandLine.Substring(strart + 2, length));
                    amount = int.Parse(commandLine.Substring(amountStart+1, amountEnd));
                    price = spend * amount;

                    totalPrice += price;
 
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice, 0:f2}");
        }
    }
}
