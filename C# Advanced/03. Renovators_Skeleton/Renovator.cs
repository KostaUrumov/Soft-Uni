using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;

        }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public Boolean Hired { get; set; }


        public override string ToString()
        {
            return $"-Renovator: {this.Name}\n--Specialty: { this.Type}\n--Rate per day: {this.Rate} BGN";
        }

    }
}
