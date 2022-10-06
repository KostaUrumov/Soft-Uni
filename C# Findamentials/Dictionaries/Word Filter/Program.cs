using System;
using System.Linq;

namespace _5._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = (string[])Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            for (int i = 0; i < command.Length; i++)
            {
                Console.WriteLine(command[i]);
            }
                
        }
    }
}
