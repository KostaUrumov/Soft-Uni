using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProductShop.DTOs
{
    public class CategoriesProductsDTO
    {
        [JsonPropertyName("CategoryId")]
        public int CategoryId { get; set; }
        [JsonPropertyName("ProductId")]
        public int ProductId { get; set; }
    }
}
