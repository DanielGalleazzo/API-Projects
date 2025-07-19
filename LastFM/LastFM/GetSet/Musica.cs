using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LastFM.GetSet
{
    public class Musica
    {
        [JsonPropertyName("artist")]
        public Artista Artista { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("date")]
        public Data Data { get; set; }


    }
}
