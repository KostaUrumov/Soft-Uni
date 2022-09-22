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

            string first = "";
            string second = "";
            int line = 0;


            for (int i = 0; i < number; i++)
            {
                string[] newLine = Console.ReadLine().Split(' ');
                line++;

                if (line % 2 == 1)
                {
                    for (int j = 0; j < newLine.Length; j++)
                    {
                        if (j == 0)
                        {
                            first += newLine[j] + " ";

                        }

                        else
                        {
                            second += newLine[j] + " ";

                        }


                    }

                }

                if (line % 2 == 0)
                {
                    for (int j = 0; j < newLine.Length; j++)
                    {
                        if (j == 0)
                        {
                            second += newLine[j] + " ";

                        }

                        else
                        {
                            first += newLine[j] + " ";

                        }


                    }

                }


            }

            Console.WriteLine(first);
            Console.WriteLine(second);

        }
    }
}
