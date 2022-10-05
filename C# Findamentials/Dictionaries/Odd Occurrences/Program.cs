using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsLine = Console.ReadLine()
                .Split(' ');


            for (int i = 0; i < wordsLine.Length; i++)
            {
                wordsLine[i] = wordsLine[i].ToLower();
            }

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in wordsLine)
            {
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 0);
                }
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
            
        }
    }
}
