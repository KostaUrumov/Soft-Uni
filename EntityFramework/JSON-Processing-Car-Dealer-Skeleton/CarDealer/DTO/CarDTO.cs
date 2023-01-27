using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarDealer.DTO
{
    public  class CarDTO
    {
        [JsonPropertyName("make")]
        public string Make { get; set; }
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonPropertyName("travelledDistance")]
        public long TravelledDistance { get; set; }
        [JsonPropertyName("partsId")]
        public List<PartCar> parts { get; set; }
    }
}
