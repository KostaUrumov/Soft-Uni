using System;

namespace MethodExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BiggestNumberChecker(); 
        }

        private static void BiggestNumberChecker()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());


            if (numberOne <= numberTwo && numberOne <= numberThree)
            {
                Console.WriteLine(numberOne);
            }

            else if (numberTwo <= numberOne && numberTwo <= numberThree)
            {
                Console.WriteLine(numberTwo);
            }

            else if (numberThree <= numberOne && numberThree <= numberTwo)
            {
                Console.WriteLine(numberThree);
            }
        }

    }
}
