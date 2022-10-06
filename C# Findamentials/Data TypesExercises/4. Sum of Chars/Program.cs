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
            int sum = 0;


            for (int i = 1; i <= number; i++)
            {
                char c = char.Parse(Console.ReadLine());
                sum += (int)c;
                
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
