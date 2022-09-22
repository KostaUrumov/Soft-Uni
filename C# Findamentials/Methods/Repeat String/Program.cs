using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeated = Repeat(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(repeated);
        }

        static string Repeat(string entry, int numberRepeat)
        {
            
            string result = "";

            for (int i = 0; i < numberRepeat; i++)
            {
                result += entry;
            }
            
            return result;
        }
    }
}