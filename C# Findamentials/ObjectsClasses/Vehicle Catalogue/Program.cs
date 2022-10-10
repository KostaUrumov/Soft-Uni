using System;
using System.Collections.Generic;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> Autos = new List<Car>();
            List<Truck> LongVehicle = new List<Truck>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] defineProperties = input.Split('/');

                if (defineProperties[0] == "Car")
                {
                    Car auto = new Car();
                    auto.Brand = defineProperties[1];
                    auto.Model = defineProperties[2];
                    auto.HorsePower = int.Parse(defineProperties[3]);
                    Autos.Add(auto);

                }

                else if (defineProperties[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = defineProperties[1];
                    truck.Model = defineProperties[2];
                    truck.Weight = int.Parse(defineProperties[3]);
                    LongVehicle.Add(truck);
                }

            }

            List<string> alfabeticalCars = new List<string>();
            for (int i = 0; i < Autos.Count; i++)
            {
                alfabeticalCars.Add(Autos[i].Brand);
            }

            List<string> alfabeticalTrucks = new List<string>();
            for (int i = 0; i < LongVehicle.Count; i++)
            {
                alfabeticalTrucks.Add(LongVehicle[i].Brand);
            }

            alfabeticalCars.Sort();
            alfabeticalTrucks.Sort();

            if (alfabeticalCars.Count > 0)
            {

            
            Console.WriteLine("Cars:");
            for (int i = 0; i < alfabeticalCars.Count; i++)
            {
                for (int p = 0; p < Autos.Count; p++)
                {
                    if (alfabeticalCars[i] == Autos[p].Brand)
                    {
                        Console.WriteLine($"{Autos[p].Brand}: {Autos[p].Model} - {Autos[p].HorsePower}hp");
                        Autos.RemoveAt(p);
                        alfabeticalCars.RemoveAt(i);
                        i = -1;
                        break;
                    }
                }
                    continue;

            }
        }
            if (alfabeticalTrucks.Count > 0)
            {


                Console.WriteLine("Trucks:");
                for (int i = 0; i < alfabeticalTrucks.Count; i++)
                {
                    for (int p = 0; p < LongVehicle.Count; p++)
                    {
                        if (alfabeticalTrucks[i] == LongVehicle[p].Brand)
                        {
                            Console.WriteLine($"{LongVehicle[p].Brand}: {LongVehicle[p].Model} - {LongVehicle[p].Weight}kg");
                            LongVehicle.RemoveAt(p);
                            alfabeticalTrucks.RemoveAt(i);
                            i = -1;
                            break;
                        }
                    }
                    continue;

                }
            }

        }


    }
}
