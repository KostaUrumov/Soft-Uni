using System;
using System.Collections.Generic;

namespace _3.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string path = Console.ReadLine();
            List<string> file = new List<string>();
           string extention = string.Empty;
            int stop = 0; 
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 46)
                {
                    stop = i;
                    
                }
            }

            for (int i = stop + 1; i < path.Length; i++)
            {
                extention+=path[i];
            }

            for (int i = stop -1 ; i >= 0; i--)
            {
                if (path[i] != 92)
                {
                    file.Add(path[i].ToString());
                }
                if (path[i] == 92)
                {
                    break;
                }
            }
            file.Reverse();
            Console.WriteLine($"File name: {string.Join("",file)}");
            Console.WriteLine($"File extension: {extention}");

        }
    }
}
