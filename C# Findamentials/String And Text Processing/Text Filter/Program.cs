using System;

namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bannedWordsEntry = Console.ReadLine();
            string [] banned = bannedWordsEntry.Split(", ");
            string textToClear = Console.ReadLine();
            

            for (int i = 0; i < banned.Length; i++)
            {
                string toReplance = string.Empty;
                while (true)
                {
                    int number = textToClear.IndexOf(banned[i]);
                    for (int h = 0; h < banned[i].Length; h++)
                    {
                        toReplance += "*";
                    }
                    if (number == -1)
                    {
                        break;

                    }
                    else
                    {
                        textToClear = textToClear.Replace(banned[i].ToString(), toReplance);
                    }
                    
                }
            }

            Console.WriteLine(textToClear);
        }
    }
}
