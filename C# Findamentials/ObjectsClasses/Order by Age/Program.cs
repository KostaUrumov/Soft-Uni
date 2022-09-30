using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    List<Person> sortedListByGrade = people.OrderByDescending(o =>o.Age).ToList();

                    for (int i = sortedListByGrade.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine($"{sortedListByGrade[i].Name} with ID: {sortedListByGrade[i].ID} is {sortedListByGrade[i].Age} years old.");
                    }
                    break;
                }

                string [] commandParts = command.Split(' ');
                for (int i = 0; i< people.Count; i++)
                {
                    if (people[i].ID == commandParts[1])
                    {
                        people[i].ID = commandParts[1];
                        people[i].Name = commandParts[0];
                        people[i].Age = int.Parse(commandParts[2]);
                        break;
                    }
                    
                }
                Person person = new Person();
                person.Name = commandParts[0];
                person.ID = commandParts[1];
                person.Age = int.Parse(commandParts[2]);
                people.Add(person);

            }
        }


        internal class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string ID { get; set; }
        }

    }
}
