using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProductShop.DTOs
{
    public class CategoryDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
