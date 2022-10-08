using System;
using System.Collections.Generic;

namespace _5._Sudents_v_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();
            while (true)
            {
                int added = 0;
                string studentInformation = Console.ReadLine();
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

                for (int i = 0; i < studentList.Count; i++)
                {
                    if (student.FirstName == studentList[i].FirstName && student.LastName == studentList[i].LastName)
                    {
                        studentList[i].FirstName = student.FirstName;
                        studentList[i].LastName = student.LastName;
                        studentList[i].Age = student.Age;
                        studentList[i].HomeTown = student.HomeTown;
                        added++;
                        continue;
                    }
                }

                studentList.Add(student);
                if (added > 0)
                {
                    studentList.RemoveAt(studentList.Count - 1);
                }
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
