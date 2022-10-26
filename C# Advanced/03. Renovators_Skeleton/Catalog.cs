using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {


        private List<Renovator> renovators = new List<Renovator>();

        public string Name { get; set; }
        public int NeededRenovators {get; set;}
        public string Project { get; set; }



        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public int Count
        {
            get { return renovators.Count; }
             
        }

        public string AddRenovator(Renovator renovator)
        {

            if (renovator.Name == "null" || renovator.Type == "null")
            {
                return "Invalid renovator's information.";
            }
            if (renovator.Name == " " || renovator.Type == " ")
            {
                return "Invalid renovator's information.";
            }

            if (this.renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";

            }
            else
            {
                this.renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            foreach (var names in this.renovators)
            {
                if (names.Name.Contains(name))
                {
                    renovators.Remove(names); 
                    return true;
                    
                }
                
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int removed = 0;
            for (int i = 0; i < this.renovators.Count; i++)
            {
                if (renovators[i].Type == type)
                {
                    removed++;
                    renovators.Remove(renovators[i]);
                }
            }
            return removed;
        }

        public Renovator HireRenovator(string name)
        {

            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Name == name)
                {
                    renovators[i].Hired = true;
                    return renovators[i];
                }

            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> ret = new List<Renovator>();
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Days >= days)
                {
                    ret.Add(renovators[i]);
                }

            }

            return ret;
        }

        public string Report()
        {
            List<Renovator> notHired = new List<Renovator>();
            string toPrint = string.Empty;

            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Hired == false)
                {
                    notHired.Add(renovators[i]);
                }
            }
           
            
            for (int i = 0; i < notHired.Count; i++)
            {
                toPrint += $"-Renovator: {notHired[i].Name}\n--Specialty:{notHired[i].Type}\n--Rate per day:{notHired[i].Rate}BGN\n";
            }

            return $"Renovators available for Project {this.Project}:\n" + toPrint;



        }

    }
}
