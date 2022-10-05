using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var wordsSynonims = new Dictionary<string, List<string>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (wordsSynonims.ContainsKey(word) == false)
                {
                    wordsSynonims.Add(word, new List<string>());
                }
                if (wordsSynonims.ContainsKey(word) == true)
                {
                    wordsSynonims[word].Add(synonim);
                }
             }

            foreach (var word in wordsSynonims)
            {
                Console.Write($"{word.Key} - ");
                for (int i = 0; i < word.Value.Count; i++)
                {
                    if (i == word.Value.Count - 1)
                    {
                        Console.Write($"{word.Value[i]}");
                    }
                    else
                    {
                        Console.Write($"{word.Value[i]}, ");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
