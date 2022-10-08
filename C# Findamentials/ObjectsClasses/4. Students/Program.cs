using System;
using System.Collections.Generic;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();
            while (true)
            {
                string studentInformation  = Console.ReadLine();
                if (studentInformation == "end")
                {
                    break;
                }
                string[] studentData = studentInformation.Split(' ');
                Student student = new Student();
                student.FirstName = studentData[0];
                student.LastName = studentData[1];
                student.Age = studentData[2];
                student.HomeTown = studentData[3];
                studentList.Add(student);
            }
            callStudentsFrom(studentList);

            static void callStudentsFrom(List<Student> studentList)
            {
                string town = Console.ReadLine();
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (town == studentList[i].HomeTown)
                    {
                        Console.WriteLine($"{studentList[i].FirstName} {studentList[i].LastName} is {studentList[i].Age} years old.");
                    }

                }
            }
        }
    }
}
