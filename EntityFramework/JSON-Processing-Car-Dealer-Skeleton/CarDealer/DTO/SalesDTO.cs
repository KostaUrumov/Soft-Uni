using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarDealer.DTO
{
    public class SalesDTO
    {
        [JsonPropertyName("carId")]
        public int CarId { get; set; }
        [JsonPropertyName("customerId")]
        public int CustomerId { get; set; }
        [JsonPropertyName("discount")]
        public decimal Discout { get; set; }
    }
}
