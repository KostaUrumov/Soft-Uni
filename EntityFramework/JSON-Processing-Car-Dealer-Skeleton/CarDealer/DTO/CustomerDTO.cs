using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarDealer.DTO
{
    public class CustomerDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime Birthdate { get; set; }

        [JsonPropertyName("isYoungDriver")]
        public bool IsYoungDriver { get; set; }
    }
}
