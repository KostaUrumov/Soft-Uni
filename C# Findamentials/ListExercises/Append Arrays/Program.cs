using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command =Console.ReadLine();
           string [] arguments = command.Split('|');
           

           List<int> numbers = new List<int>();


            for (int i = arguments.Length - 1; i >= 0; i--)
            {
                string line = arguments[i];
                string[] parts = line.Split(' ');

                for (int w = 0; w < parts.Length; w++)
                {
                    string c = parts[w];
                    if (c == "")
                    {
                        continue;
                    }
                    else
                    {
                        numbers.Add(int.Parse(parts[w]));
                    }

                }


              
                
            }
          
                Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
