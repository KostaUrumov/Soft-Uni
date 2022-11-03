using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            string[] parts = commandLine
                .Split("|");

            Regex partOneCapital = new Regex(@"([\W]{1})[A-Z]+\1");
            MatchCollection capitalLetters = partOneCapital.Matches(parts[0]);
            string capital = capitalLetters[0].Value;
            capital = capital.Remove(0, 1);
            capital = capital.Remove(capital.Length - 1, 1);
            Dictionary<string, int> results = new Dictionary<string, int>();
            for (int i = 0; i < capital.Length; i++)
            {
                results.Add(capital[i].ToString(), 0);
            }

            Regex partTwoWordsLength = new Regex(@"([0-9]{2}):([0-9]{2})");
            MatchCollection wordsLgth = partTwoWordsLength.Matches(parts[1]);

            for (int i = 0; i < capital.Length; i++)
            {
                for (int r = 0; r < wordsLgth.Count; r++)
                {
                    int nmber = Convert.ToInt32(capital[i]);
                    if (nmber == int.Parse(wordsLgth[r].Groups[1].ToString()))
                    {
                        results[capital[i].ToString()] = 1 + int.Parse(wordsLgth[r].Groups[2].ToString());
                    }
                }

            }

            string[] listOfWords = parts[2]
                .Split(" ");

            for (int y = 0; y < listOfWords.Length; y++)
            {
                if (results.ContainsKey(listOfWords[y][0].ToString()))
                {
                    int hohoho = results[listOfWords[y][0].ToString()];
                    if (hohoho == listOfWords[y].Length)
                    {
                        Console.WriteLine(listOfWords[y]);


                    }
                }

            }

        }
    }
}
