﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Position
    {
        public Position()
        {
            this.Players = new List<Player>();
        }
        [Key]
        public int PositionId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
