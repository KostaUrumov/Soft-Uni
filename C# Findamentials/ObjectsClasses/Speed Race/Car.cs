using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Speed_Race
{ 
        internal class Car
        {

            public string Model { get; set; }
            public double FuelConsumtptionPerKM { get; set; }
            public double TraveledDistance { get; set; }
            public double FuelAmount { get; set; }


            public void Drive(double km, Car car)
            {
                double fuel = car.FuelConsumtptionPerKM * km;
                if (fuel > car.FuelAmount)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    car.TraveledDistance += km;
                    car.FuelAmount -= km * car.FuelConsumtptionPerKM;
                }

            }
        }
}
