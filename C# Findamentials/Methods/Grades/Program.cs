﻿using System;

namespace I._Declaring_and_Invoking_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeChecker();
        }
        static void GradeChecker()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 3.00)
            {
                Console.WriteLine("Fail");
            }

            else if (grade > 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }

            else if (grade > 3.49 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }

            else if (grade > 4.49 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade > 5.49 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }

        }


    }
}
