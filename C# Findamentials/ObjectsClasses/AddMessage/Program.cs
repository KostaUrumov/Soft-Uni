using System;
using System.Collections.Generic;

namespace Objects_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string phrases = "Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can’t live without this product.";
            string [] linePhrases = phrases.Split(',');
            string events = "Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!";
            string[] lineEvents = events.Split(',');
            string authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva";
            string[] lineAuthors = authors.Split(',');
            string cities = "Burgas, Sofia, Plovdiv, Varna, Ruse";
            string[] lineCities = cities.Split(',');

            string resultPhrase = "";
            string resultEvents = "";
            string resultAuthor = "";
            string resultCity = "";



            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                for (int c = 0; c < linePhrases.Length; c++)
                 {
                    int index = rand.Next(linePhrases.Length);
                    resultPhrase = linePhrases[index];
                    break;

                 }
                for (int h = 0; h < lineEvents.Length; h++)
                {
                    int index = rand.Next(lineEvents.Length);
                    resultEvents = linePhrases[index];
                    break;

                }
                for (int t = 0; t < lineAuthors.Length; t++)
                {
                    int index = rand.Next(lineAuthors.Length);
                    resultAuthor = lineAuthors[index];
                    break;

                }

                for (int q = 0; q < lineCities.Length; q++)
                {
                    int index = rand.Next(lineCities.Length);
                    resultCity = lineCities[index];
                    break;

                }
                Console.WriteLine($"{resultPhrase} {resultEvents} {resultAuthor} {resultCity}");

            }
            
        }

    }
}
