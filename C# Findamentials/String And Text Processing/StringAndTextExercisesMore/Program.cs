using System;
using System.Text;

namespace StringAndTextExercisesMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string age = string.Empty;

            for (int i = 0; i < number; i++)
            {
                string props = Console.ReadLine();
                int start = props.IndexOf("@");
                int end = props.IndexOf("|");
                int lengthOfName = end - start;
                name = props.Substring(start + 1, lengthOfName - 1);
                int startAge = props.IndexOf("#");
                int endAge = props.IndexOf("*");
                int ageLength = endAge - startAge;
                age = props.Substring(startAge +1 , ageLength-1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
