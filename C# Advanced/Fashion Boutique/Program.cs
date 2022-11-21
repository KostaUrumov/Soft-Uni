using System;
using System.Collections;
using System.Collections.Generic;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] values = numbers.Split(' ');
            Stack<int> orderValues = new Stack<int>();
            for (int i = 0; i < values.Length; i++)
            {
                orderValues.Push(int.Parse(values[i]));
            }

            int rackCapacity = int.Parse(Console.ReadLine());
            int useage = 0;
            int usedracks = 1;

            while (orderValues.Count > 0)
            {
                useage += orderValues.Peek();
                if (useage > rackCapacity)
                {

                    usedracks++;
                    useage = 0;
                }
                else
                {
                    orderValues.Pop();
                }
                    
            }

            Console.WriteLine(usedracks);
        }
    }
}
