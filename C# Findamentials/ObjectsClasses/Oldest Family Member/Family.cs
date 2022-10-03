using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Oldest_Family_Member
{
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
            for (int i = 0; i < people.Count ; i++)
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

}
