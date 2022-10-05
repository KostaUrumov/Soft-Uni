using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> values = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!values.ContainsKey(number))
                {
                    values.Add(number,0);
                }
                if (values.ContainsKey(number))
                {
                    values[number]++;
                }

            }

            foreach (var times in values)
            {
                Console.WriteLine($"{times.Key} -> {times.Value}");
            }

        }
    }
}
