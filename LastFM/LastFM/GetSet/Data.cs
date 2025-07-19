using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LastFM.GetSet
{
    public class Data
    {
        [JsonPropertyName("uts")]
        public string Uts { get; set; }

        [JsonPropertyName("#text")]
        public string Texto { get; set; }
    }
}
