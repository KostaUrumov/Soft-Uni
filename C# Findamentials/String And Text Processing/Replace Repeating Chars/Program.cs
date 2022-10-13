using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            StringBuilder result = new StringBuilder();
            result.Append(command[0]);

            for (int i = 0; i < command.Length; i++)
            {
                
                if (command[i] != command[i + 1])
                { 
                    result.Append(command[i +1 ]);
                }
                if (i + 1 == command.Length - 1)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
