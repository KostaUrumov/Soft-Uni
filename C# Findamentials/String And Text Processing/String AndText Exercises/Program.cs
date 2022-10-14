using System;
using System.Collections.Generic;

namespace String_AndText_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command  = Console.ReadLine();
            string[] allUsernames = command
                .Split(", ");
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < allUsernames.Length; i++)
            {
                int count = 0;
                if (allUsernames[i].Length >= 3 && allUsernames[i].Length <= 16)
                {
                    
                    for (int k = 0; k < allUsernames[i].Length; k++)
                    {
                     int number = Convert.ToInt32(allUsernames[i][k]);
                        if (number >= 48 && number <= 57)
                        {
                            count++;
                        }
                        if ((number >= 65 && number <= 90) || (number >= 97 && number <= 122))
                        {
                            count++;
                        }
                        if (number == 95 || number == 45)
                        {
                            count++;
                        }
                        if (count == allUsernames[i].Length)
                        {
                            validUsernames.Add(allUsernames[i]);
                        }
                    
                    }
                }
                

            }

            foreach (string username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }


    }
}
