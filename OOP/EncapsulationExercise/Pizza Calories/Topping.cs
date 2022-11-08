using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Pizza_Calories
{
    public class Topping
    {
        const double modifier = 2;
        private string type;
        private double grams;


        public Topping(string type, double grams)
        {
            Type = type;
            Grams = grams;
        }
        public string Type
        {
            get { return type; }
            private set
            {
                if (value == "meat" || value == "veggies" || value == "cheese" || value == "sauce")
                {
                    type = value;
                }

                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }


        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value > 0 && value <= 50)
                {
                    this.grams = value;
                }
                else
                {
                    string toPrint = string.Empty;
                    for (int i = 0; i < this.type.Length; i++)
                    {
                        if (i == 0)
                        {
                            toPrint += char.ToUpper(this.type[i]);
                        }
                        else
                        {
                            toPrint += this.type[i];
                        }
                        
                    }
                    
                    throw new ArgumentException($"{toPrint} weight should be in the range [1..50].");
                }

            }
        }




        public void calculateCal(double grams, string type)
        {
            double result = grams * 2;
            if (type == "meat")
            {
                result *= 1.2;
            }
            if (type == "veggies")
            {
                result *= 0.8;
            }
            if (type == "cheese")
            {
                result *= 1.1;
            }
            if (type == "sauce")
            {
                result *= 0.9;
            }


            Console.WriteLine($"{result:f2}");
        }



    }
}
