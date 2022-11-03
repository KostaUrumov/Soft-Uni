using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex one = new Regex(@"\+359([ -])[2]\1[0-9]{3,}\1[0-9]{4}\b");



            string line = Console.ReadLine();

            MatchCollection matches = one.Matches (line);
            for (int i = 0; i < matches.Count; i++)
            {
                if (i == matches.Count - 1)
                {
                    Console.Write($"{matches[i]}");
                    continue;
                }
                else
                {
                Console.Write($"{matches[i]}, ");
                }
            }
            
        }

    }
}
