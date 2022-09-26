using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                string studentInformation = Console.ReadLine();
                String[] infoPerStudent = studentInformation.Split(' ');
                Student student = new Student();
                student.FirstName = infoPerStudent[0];
                student.LastName = infoPerStudent[1];
                student.Grade = double.Parse(infoPerStudent[2]);
                students.Add(student);
            }


            List<Student> sortedListByGrade = students.OrderByDescending(o => o.Grade).ToList();

            for (int i = 0; i < sortedListByGrade.Count; i++)
            {
                Console.WriteLine($"{sortedListByGrade[i].FirstName} {sortedListByGrade[i].LastName}: {sortedListByGrade[i].Grade, 0:f2}" );

            }

        }
    }
}
