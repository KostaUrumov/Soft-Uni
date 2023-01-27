using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProductShop.DTOs
{
    public class ProductDTO
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Price")]
        public decimal Price { get; set; }
        [JsonPropertyName("SellerId")]
        public int SellerId  { get; set; }
        [JsonPropertyName("BuyerId")]
        public int? BuyerId { get; set; }

    }
}
