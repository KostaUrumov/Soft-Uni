using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(Operation(numberOne,  numberTwo, operation));

        }

        static int Operation(int numberOne, int numberTwo, string operation)
        {
            int result = 0;
            if (operation == "+")
            {
                result = numberOne + numberTwo;
            }

            else if (operation == "-")
            {
                result = numberOne - numberTwo;

            }

            else if (operation == "*")
            {
                result = numberOne * numberTwo;
            }

            else if (operation == "/")
            {
                result = numberOne / numberTwo;
            }

            return result;
        }
    }
}
