using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }

        public int SquadNumber { get; set; }
        
        [ForeignKey(nameof(TeamId))]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey(nameof(PositionId))]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [Required]
        public bool isInjured { get; set;}
    }
}
