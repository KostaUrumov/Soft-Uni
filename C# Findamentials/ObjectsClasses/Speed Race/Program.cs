using System;
using System.Collections.Generic;

namespace _4._Speed_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> Autos = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string line = Console.ReadLine();
                string[] carsProperties = line.Split(" ");
                Car car = new Car();
                car.Model = carsProperties[0];
                car.FuelAmount = double.Parse(carsProperties[1]);
                car.FuelConsumtptionPerKM = double.Parse(carsProperties[2]);
                Autos.Add(car);
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    for (int i = 0; i < Autos.Count; i++)
                    {
                        Console.WriteLine($"{Autos[i].Model} {Autos[i].FuelAmount,0:f2} {Autos[i].TraveledDistance}");
                    }
                    break;
                }

                string[] commandParts = command.Split(" ");
                for (int i = 0; i < Autos.Count; i++)
                {
                    if (commandParts[1] == Autos[i].Model)
                    {
                        Car car = Autos[i];
                        double km = double.Parse(commandParts[2]);
                        car.Drive(km, Autos[i]);
                    }

                }

            }

        }
    }
}
