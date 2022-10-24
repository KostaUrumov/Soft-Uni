using System;

namespace BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double totalEarnedMoney = 0;
            int numberCities = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCities; i++)
            {
                string city = Console.ReadLine();
                double overallMoneyGet = double.Parse(Console.ReadLine());
                double costs = double.Parse(Console.ReadLine());
                double earnedCity = 0;

                if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0)
                {
                    earnedCity = (overallMoneyGet * 0.9) - costs;
                    totalEarnedMoney += earnedCity;
                    Console.WriteLine($"In {city} Burger Bus earned {earnedCity,0:f2} leva.");

                    continue;
                }

                if ((i + 1) % 3 == 0)
                {
                    costs = costs*1.5 ;
                    earnedCity = overallMoneyGet - costs;
                    totalEarnedMoney += earnedCity;
                    Console.WriteLine($"In {city} Burger Bus earned {earnedCity, 0:f2} leva.");
                    continue;
                }

                if ((i + 1) % 5 == 0)
                {
                    
                    earnedCity = (overallMoneyGet*0.9) - costs;
                    totalEarnedMoney += earnedCity;
                    Console.WriteLine($"In {city} Burger Bus earned {earnedCity,0:f2} leva.");
                    continue;
                }


                earnedCity = overallMoneyGet - costs;
                totalEarnedMoney += earnedCity;
                Console.WriteLine($"In {city} Burger Bus earned {earnedCity,0:f2} leva.");

            }

            Console.WriteLine($"Burger Bus total profit: {totalEarnedMoney, 0:f2} leva.");


        }
    }
}
