using System;
using System.Collections.Generic;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string [] commandSplit = command.Split(' ');
            string newString = string.Empty;
            foreach (var moni in commandSplit)
            {
                if (moni.Contains(moni))
                {
                    for (int i = 0; i < moni.Length; i++)
                    {
                        newString += moni;
                    }
                }
            }
            Console.WriteLine(newString);
            
        }
    }
}
