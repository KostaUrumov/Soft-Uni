using System;
using System.Collections.Generic;

namespace _2._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            
            for (int i = 0; i < numberOfPeople; i++)
            {
                string personData = Console.ReadLine();
                string[] dataPerPerson = personData.Split(' ');
                Person person = new Person();
                person.Name = dataPerPerson[0];
                person.Age = int.Parse(dataPerPerson[1]);
                Family.Member(person, people);
            }



            Family.OldestMember(people);
            
        }

        internal class Family
        {
            public List<Person> ListOfPeople { get; set; }


            public static void Member(Person person, List<Person> people)
            {

                people.Add(person);

            }

            public static void OldestMember(List<Person> people)
            {
                int age = int.MinValue;
                int index = -5;
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Age > age)
                    {
                        age = people[i].Age;
                        index = i;
                    }
                }

                Console.WriteLine($"{people[index].Name} {people[index].Age}");
            }
        }
        internal class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }

}
