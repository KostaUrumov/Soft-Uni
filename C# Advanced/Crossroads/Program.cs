using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLigtDuration = int.Parse(Console.ReadLine()); 
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> carlsInLane = new Queue<string>();
            int passed = 0;
            int crash = 0;
            

            while (true)
            {
                int greenDefault = greenLigtDuration;
                int totalSeconds = 0;
                string command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{passed} total cars passed the crossroads.");
                    break;
                }
                if (command != "green")
                {
                    carlsInLane.Enqueue(command);   
                }
                if (command == "green")
                {
                    while (carlsInLane.Count > 0)
                    { 
                        string car = carlsInLane.Peek();
                        if (totalSeconds >= greenLigtDuration)
                        {
                            break;
                        }
                        
                        if (car.Length <= greenDefault)
                        {
                            greenDefault -= car.Length;
                            carlsInLane.Dequeue();
                            totalSeconds += car.Length;
                            passed++;   
                            continue;
                        }

                        if (car.Length > greenDefault)
                        {
                            if (car.Length <= freeWindow + greenDefault)
                            {
                                int timeLeft = freeWindow + greenDefault;
                                timeLeft -= car.Length;
                                totalSeconds += car.Length;
                                carlsInLane.Dequeue();
                                passed++;
                            }

                            if (car.Length > freeWindow + greenDefault)
                            {
                                int result = freeWindow + greenDefault - car.Length;
                                
                                result = 0 - result;
                                List<string> lines = new List<string>();
                                for (int i = 0; i < car.Length; i++)
                                {
                                    lines.Add(car[i].ToString());

                                }
                                lines.Reverse();
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {lines[result-1]}.");
                                crash++;
                                break;
                            }
                        }
                    }

                    if (crash > 0)
                    {
                        break;
                    }
                }
            
            }
        }
    }
}
