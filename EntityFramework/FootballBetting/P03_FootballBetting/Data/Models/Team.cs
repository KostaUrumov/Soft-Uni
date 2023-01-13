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

        [Required]
        [ForeignKey(nameof(ColorId))]
        public int PrimaryKitColorId { get; set; }
        public Color ColorPrimary { get; set; }

        [ForeignKey(nameof(ColorId))]
        public int SecondaryKitColorId { get; set; }
        public Color ColorSecond { get; set; }

        [ForeignKey(nameof(TownId))]
        public int TownId { get;}
        public Town Town { get; set; }
    }
}
