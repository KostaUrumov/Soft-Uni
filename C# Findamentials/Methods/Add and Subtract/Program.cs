using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int result = AddNumbers(numberOne, numberTwo, numberThree);

            Console.WriteLine(MinusNumbers(numberOne, numberTwo, numberThree));
            
        }

        private static int MinusNumbers(int numberOne, int numberTwo, int numberThree)
        {

            int result = AddNumbers(numberOne, numberTwo, numberThree) - numberThree;
            return result;
        }

        static int AddNumbers(int numberOne, int numberTwo, int numberThree)
        {
            

            int sum =  numberOne + numberTwo;
            return sum;
        }

    }
}
