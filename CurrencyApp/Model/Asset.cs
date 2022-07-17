using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyApp.Model
{
    internal class Asset
    {
        [JsonPropertyName("asset_id")]
        public string? Asset_id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("change_1h")]
        public decimal Change_1h { get; set; }

        [JsonPropertyName("change_24h")]
        public decimal Change_24h { get; set; }

        [JsonPropertyName("change_7d")]
        public decimal Change_7d { get; set; }

        [JsonPropertyName("volume_24h")]
        public decimal Volume_24h { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("updated_at")]
        public string? Updated_at { get; set; }
    }
}
