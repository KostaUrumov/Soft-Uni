﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Bets = new List<Bet>();
        }
        [Key]
        public int GameId { get; set; }

        [ForeignKey(nameof(HomeTeamId))]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        [ForeignKey(nameof(AwayTeamId))]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get;set; }
        [Required]
        public DateTime DateTime { get; set; }
        public double? HomeTeamBetRate { get; set; }
        public double? AwayTeamBetRate { get;set; }
        public double? DrawBetRate { get; set; }
        public string Result { get; set; }

        public ICollection<Bet> Bets { get; set; }


    }
}
