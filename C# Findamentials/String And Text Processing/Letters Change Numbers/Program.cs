using System;
using System.Text;

namespace _8.__Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalResult = 0;
            string command = Console.ReadLine();
            string[] differentparts = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            

            for (int i = 0; i < differentparts.Length; i++)
            {
                double divider = -1;
                double multiplier = -1;
                double minus = -1;
                double plus = -1;
                string stringNumber = string.Empty;

                for (int u = 0; u < differentparts[i].Length; u++)
                {
                    if (u > 0 && u < differentparts[i].Length - 1)
                    {
                        stringNumber += (differentparts[i][u]);
                    }
                    if (u == 0)
                    {
                        if (differentparts[i][u] >= 65 && differentparts[i][u] <= 90)
                        {
                            divider = differentparts[i][u] - 64;
                        }

                        if (differentparts[i][u] >= 97 && differentparts[i][u] <= 122)
                        {
                            multiplier = differentparts[i][u] - 96;
                        }

                    }


                    if (u == differentparts[i].Length - 1)
                    {
                        if (differentparts[i][u] >= 97 && differentparts[i][u] <= 122)
                        {
                            plus = differentparts[i][u] - 96;
                        }

                        if (differentparts[i][u] >= 65 && differentparts[i][u] <= 90)
                        {
                            minus = differentparts[i][u] - 64;
                        }

                    }
                }
                double numberTpChange = double.Parse(stringNumber);
                    if (divider >= 0)
                    {
                        numberTpChange = numberTpChange / divider;
                    }
                    if (multiplier >= 0)
                    {
                        numberTpChange = numberTpChange * multiplier;
                    }

                    if (minus >= 0)
                    {
                        numberTpChange = numberTpChange - minus;
                    }

                    if (plus >= 0)
                    {
                        numberTpChange = numberTpChange + plus;
                    }


                    totalResult += numberTpChange;

                

            }

            Console.WriteLine($"{totalResult, 0:f2}");
        }
    }
}
