using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            
            int result = 0;

            string text = number.ToString();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int numberToAdd = int.Parse(char.ToString(c));
                result += numberToAdd;
            }

            Console.WriteLine(result);

        }
    }
}