using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarDealer.DTO
{
    public class PartsDTO
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Price")]
        public decimal Price { get; set; }
        [JsonPropertyName("Quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("SupplierId")]
        public int SupplierId { get; set; }
    }
}
