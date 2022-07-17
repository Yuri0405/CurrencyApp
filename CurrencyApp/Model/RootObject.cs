using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyApp.Model
{
    internal class RootObject
    {
        [JsonPropertyName("assets")]
        public List<Asset>? Assets { get; set; }
    }
}
