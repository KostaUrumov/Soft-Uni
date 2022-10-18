using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split(' ');
            string toAdd = string.Empty;
            int asciiNumber = 0;
            while (true)
            {
                
                string phrase = Console.ReadLine();
                int g = 0;
                if (phrase == "find")
                {
                    break;
                }
                string result = string.Empty;

                for (int i = 0; i < phrase.Length; i++)
                {
                    if (i < keys.Length)
                    {
                        asciiNumber = phrase[i];
                        asciiNumber = asciiNumber - int.Parse(keys[i]);
                        result += ((char)asciiNumber);
                    }

                    if (i >= keys.Length)
                    {
                        if (g != keys.Length)
                        {
                            asciiNumber = phrase[i];
                            asciiNumber = asciiNumber - int.Parse(keys[g]);
                            result += ((char)asciiNumber);
                            g++;
                            continue;
                        }

                        if (g == keys.Length)
                        {
                            g = 0;
                            asciiNumber = phrase[i];
                            asciiNumber = asciiNumber - int.Parse(keys[g]);
                            result += ((char)asciiNumber);
                            g++;
                        }
                      
                    }
                }

                
                int typeStart = result.IndexOf("&");
                string removed = result.Remove(typeStart, 1);
                typeStart = typeStart + 1;
                int typeEnd = removed.IndexOf("&");
                
                string type = result.Substring(typeStart, typeEnd + 1 - typeStart);

                int startCoordinates = result.IndexOf("<");
                int endCoordinates = result.IndexOf(">");
                string coordinates = result.Substring(startCoordinates + 1, endCoordinates - startCoordinates - 1);

                Console.WriteLine($"Found {type} at {coordinates}");


            }
        }
    }
}
