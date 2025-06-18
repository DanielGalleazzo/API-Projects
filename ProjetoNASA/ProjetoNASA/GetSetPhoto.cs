using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NASA_API
{
    public class GetSetDayPhoto
    {
        [JsonPropertyName("title")]
        public string title { get; set; }
        [JsonPropertyName("date")]
        public DateTime date { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
