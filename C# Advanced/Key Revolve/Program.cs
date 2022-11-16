using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Key_Revolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            string bulletSize = Console.ReadLine();
            string[] bulletParts = bulletSize.Split(" ");
            string[] locksSize = Console.ReadLine()
                .Split(" ");
            int budget = int.Parse(Console.ReadLine());


            Stack<int> bulletsSize = new Stack<int>();
            Queue<int> locks = new Queue<int>();



            for (int i = 0; i < bulletParts.Length; i++)
            {
                bulletsSize.Push(int.Parse(bulletParts[i]));
            }
            for (int i = 0; i < locksSize.Length; i++)
            {
                locks.Enqueue(int.Parse(locksSize[i]));
            }
            int numberBullets = 0;
            int used = 0;


            
             while (bulletsSize.Count > 0)
             {
                if (used == gunBarrel)
                {
                    used = 0;
                    Console.WriteLine("Reloading!");
                }

                if (locks.Count == 0)
                {
                    budget = budget - (bulletPrice * numberBullets);
                    Console.WriteLine($"{bulletsSize.Count} bullets left. Earned ${budget}");
                    break;
                }

                if (bulletsSize.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    bulletsSize.Pop();
                    numberBullets++;
                    used++;
                    continue;
                }

                if (bulletsSize.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletsSize.Pop();
                    locks.Dequeue();
                    used++;
                    numberBullets++;
                }

             }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

            if (locks.Count == 0 && bulletsSize.Count == 0)
            {
                budget = budget - (bulletPrice * numberBullets);
                Console.WriteLine($"{bulletsSize.Count} bullets left. Earned ${budget}");
            }

        }
    }
}
