using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.HomeGames = new List<Game>();
            this.AwayGames = new List<Game>();
            this.Players = new List<Player>();
        }
       
        [Key]
        public int TeamID { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        [MaxLength(3)]
        [MinLength(3)]
        public string? Initials { get; set; }

        [Required]
        public decimal Budget { get; set; }

        
        [ForeignKey(nameof(PrimaryKitColorId))]
        public int PrimaryKitColorId { get; set; }
        public Color color { get; set; }

        
        [ForeignKey(nameof(SecondaryKitColorId))]
        public int SecondaryKitColorId { get; set; }
        public Color Color { get; set; }

        [ForeignKey(nameof(TownId))]
        public int TownId { get;}
        public Town Town { get; set; }

        public ICollection<Game> HomeGames { get; set; }
        public ICollection<Game> AwayGames { get; set; }
        public ICollection<Player> Players { get; set; }



    }
}
