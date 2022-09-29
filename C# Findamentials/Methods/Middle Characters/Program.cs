using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiddleCharacter("line");
        }


        static void MiddleCharacter(string line)
        {
           line = Console.ReadLine();

            int length = line.Length;
            

            if (length % 2 == 0)
            {
                int halfLength = length / 2;
                for (int i = 0; i < line.Length; i++)
                {
                    if (i == halfLength - 1 || i == halfLength)
                    {
                        Console.Write($"{line[i]}");
                    }
                }
            }

            if (length % 2 == 1)
            {
                int halfLength = (length - 1) / 2;

                for (int i = 0; i < line.Length; i++)
                {
                    if (i == halfLength)
                    {
                        Console.WriteLine(line[i]);
                        break;
                    }

                }
            }

            
        }
            
    }
}
