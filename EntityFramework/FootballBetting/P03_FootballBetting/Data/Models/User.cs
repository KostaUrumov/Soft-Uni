using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        
        [DefaultValue(0.00)]
        public decimal Balance { get; set; }

    }
}
