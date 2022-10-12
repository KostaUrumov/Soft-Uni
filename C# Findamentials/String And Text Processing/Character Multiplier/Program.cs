using System;
using System.Collections.Generic;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            Console.WriteLine(CalculateNumber(one));
        }

        static int CalculateNumber(string one)
        {
            string[] properties = one.Split(' ');
            int result = 0;
            int toAdd = 0;
            
            if (properties[0].Length > properties[1].Length)
            {
                for (int i = 0; i < properties[0].Length; i++)
                {
                    if (i < properties[1].Length)
                    {
                       toAdd = properties[0][i] * properties[1][i];
                       result+= toAdd;
                        continue;
                    }
                    if (i >= properties[1].Length)
                    {
                        result+=properties[0][i];
                    }
                    
                }
            }

            if (properties[0].Length <= properties[1].Length)
            {
                for (int i = 0; i < properties[1].Length; i++)
                {
                    if (i < properties[0].Length)
                    {
                        toAdd = properties[0][i] * properties[1][i];
                        result += toAdd;
                        continue;
                    }
                    if (i >= properties[0].Length)
                    {
                        result += properties[1][i];
                    }
                    
                }

            }

            return result; 
        }
    }
}
