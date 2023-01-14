using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.HomeGround = new List<Team>();
        }
        [Key]
        public int TownId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Team> HomeGround { get; set; }
    }
}
