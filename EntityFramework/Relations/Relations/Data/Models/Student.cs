using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

    }
}
