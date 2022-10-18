using System;
using System.Text;

namespace _2._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            int numberone = Convert.ToInt32(one);
            int numbertwo = Convert.ToInt32(two);
            string commandLine = Console.ReadLine();
            int result = 0;

            if (numberone < numbertwo)
            for (int i = 0; i < commandLine.Length; i++)
            {
                    if (commandLine[i] > numberone && commandLine[i] < numbertwo)
                    {
                        result+= Convert.ToInt32(commandLine[i]);
                    }
            }

            if (numberone > numbertwo)
            {


                for (int i = 0; i < commandLine.Length; i++)
                {
                    if (commandLine[i] > numbertwo && commandLine[i] < numberone)
                    {
                        result += Convert.ToInt32(commandLine[i]);
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
