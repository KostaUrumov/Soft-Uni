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


            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int liftedPeople = 0;

            int course = 0;

            while (liftedPeople < numberOfPeople)
             { 
                course++;
                liftedPeople += capacity;
             }

            Console.WriteLine(course);

        }
    }
}