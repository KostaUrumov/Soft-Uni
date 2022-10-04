using System;
using System.Collections.Generic;

namespace _3.Rawa_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVehicles = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(); 

            for (int i = 0; i < numberOfVehicles; i++)
            {
                string vehicle = Console.ReadLine();
                string [] properties = vehicle.Split(' ');

                Car car = new Car();
                car.Model = properties[0];
                car.EnginePower = int.Parse(properties[2]);
                car.EngineSpeed = int.Parse(properties[1]);
                car.cargoType = properties[4];
                car.CargoWeight = int.Parse(properties[3]);

                cars.Add(car);
            }

            string commandLine = Console.ReadLine();

            for (int i = 0; i < cars.Count; i++)
            {
                if (commandLine == "fragile" && cars[i].cargoType == commandLine && cars[i].CargoWeight < 1000)
                {
                    Console.WriteLine($"{cars[i].Model}");
                }

                else if (commandLine == "flamable" && cars[i].cargoType == commandLine && cars[i].EnginePower > 250)
                {
                    Console.WriteLine($"{cars[i].Model}");
                }
            }
           

        }

        internal class Car
        {
            public string Model { get; set; }
            public int EnginePower { get; set; }
            public int EngineSpeed { get; set; }
            public int CargoWeight { get; set; }
            public string cargoType { get; set; }

        }
    }
}
