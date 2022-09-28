using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarectersInRange('a', 'b');
        }

        static void CarectersInRange(char a , char b)
        {

          a = char.Parse(Console.ReadLine());
          b = char.Parse(Console.ReadLine());

            int numberOne = a;
            int numberTwo = b;

            if (numberTwo < numberOne)
            {
                numberOne = numberTwo;
                numberTwo = a;
            }

            

            for (int i = numberOne + 1; i < numberTwo; i++)
            {
                char c = (char)i;
                Console.Write($"{c} ");
            }

            

        }
    }
}
