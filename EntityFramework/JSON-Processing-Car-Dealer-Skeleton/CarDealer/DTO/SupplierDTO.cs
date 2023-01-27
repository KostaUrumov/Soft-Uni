using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarDealer.DTO
{
    public class SupplierDTO
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("IsImporter")]
        public bool isImporter { get; set; }
    }
}
