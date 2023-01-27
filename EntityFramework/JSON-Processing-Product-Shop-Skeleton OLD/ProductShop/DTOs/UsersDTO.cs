using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs
{
    public class UsersDTO
    {
        [JsonProperty("firstName")]
        public string Firstname { get; set; }
        [JsonProperty("lastName")]
        public string Lastname { get; set; }
        [JsonProperty("age")]
        public int? Age { get; set; }

    }
}
