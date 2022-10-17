using System;

namespace _5._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string characters = string.Empty;
            string letters = string.Empty;
            string numbers = string.Empty;
            //string [] commandChars = command.Split('');
            for (int i = 0; i < command.Length; i++)
            {
                //char c = command[i];
                //int number = Convert.ToInt32(c);
                if ((command[i] >= 65 && command[i] <= 90) || (command[i] >= 97 && command[i] <= 122))
                {
                    letters += command[i];
                }
                else if ((command[i] <= 47) || (command[i] >= 58 && command[i] <= 64) || (command[i] >= 91 && command[i] <= 96) || (command[i] >= 123 && command[i] <= 127))
                {
                    characters += command[i];
                }
                else if (command[i] >= 48 && command[i] <= 57)
                {
                    numbers+= command[i];
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
