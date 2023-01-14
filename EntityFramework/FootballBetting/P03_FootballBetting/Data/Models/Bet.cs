using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Bet
    {
        
        [Key]
        public int BetId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Prediction { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }
        public Game Game { get; set; }

       
    }
}
