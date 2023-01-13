using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.CourseEnrollments = new List<StudentCourse>();
            this.HomeworkSubmissions = new List<Homework>();

        }
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime  RegisteredOn { get; set; }

        public DateTime?  Birthday  { get; set; }

        public ICollection<StudentCourse> CourseEnrollments { get; set; }

        public ICollection<Homework> HomeworkSubmissions { get; set; }

    }
}
