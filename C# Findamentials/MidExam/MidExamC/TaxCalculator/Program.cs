using System;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalTax = 0;

            string[] carsProps = Console.ReadLine()
                .Split(">>");
            for (int i = 0; i < carsProps.Length; i++)
            {
                double taxCar = 0;
                string[] cars = carsProps[i].Split(" ");
                if (cars[0] == "family")
                {
                    taxCar += 50;
                    taxCar -= int.Parse(cars[1]) * 5;
                    taxCar += (int.Parse(cars[2]) /3000)  * 12;
                    totalTax += taxCar;

                    Console.WriteLine($"A {cars[0]} car will pay {taxCar, 0:f2} euros in taxes.");
                    continue;
                }

                if (cars[0] == "heavyDuty")
                {
                    taxCar += 80;
                    taxCar -= int.Parse(cars[1]) * 8;
                    taxCar += (int.Parse(cars[2]) / 9000) * 14;
                    totalTax += taxCar;

                    Console.WriteLine($"A {cars[0]} car will pay {taxCar,0:f2} euros in taxes.");
                    continue;

                }
                if (cars[0] == "sports")
                {
                    taxCar += 100;
                    taxCar -= int.Parse(cars[1]) * 9;
                    taxCar += (int.Parse(cars[2]) / 2000) * 18;
                    totalTax += taxCar;

                    Console.WriteLine($"A {cars[0]} car will pay {taxCar,0:f2} euros in taxes.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTax,0:f2} euros in taxes.");
        }
    }
}
