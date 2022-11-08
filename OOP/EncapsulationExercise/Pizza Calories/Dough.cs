using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Dough
    {
        private string flourType;

        private string bakingTechnique;
        private double grams;

        public Dough(string flouerType, string bakingTechnique, double grams )
        {
            FlouerType = flouerType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
            
        }

        public string FlouerType
        {
            get { return this.flourType; }
            set 
            {
                if (value == "white" || value == "wholegrain")
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                
            }
        }
         
        

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            private set
            {
                if (value == "crispy" || value == "chewy" ||value == "homemade")
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Grams
        {
            get { return this.grams; }
            private set
            {
                if (value > 0 && value <= 200)
                {
                    this.grams = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        public void  DoughCalories(double grams, string flouerType, string bakingTechnique)
        {
            double result = grams * 2;
            if (flouerType == "white")
            {
                result *= 1.5;
            }
            if (bakingTechnique == "crispy")
            {
                result *= 0.9;
            }
            if (bakingTechnique == "chewy")
            {
                result *= 1.1;
            }
            Console.WriteLine($"{result :f2}");
            
        }
    }
}
