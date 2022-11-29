using System;
using System.Collections;
using System.Collections.Generic;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsPassingPerGreenLight = int.Parse(Console.ReadLine());
            int passedCars = 0;
            Queue<string> carsWaiting = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input != "green")
                {
                    carsWaiting.Enqueue(input);
                }
                if (input == "green")
                {
                    for (int i = 0; i < carsPassingPerGreenLight; i++)
                    {
                        if (carsWaiting.Count > 0)
                        {
                        Console.WriteLine($"{carsWaiting.Dequeue()} passed!");
                        passedCars++;
                        }
                        

                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
