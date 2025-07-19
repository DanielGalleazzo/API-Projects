using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LastFM.GetSet
{
    public class Root
    {
        [JsonPropertyName("recenttracks")]
        public MusicasRecentes RecentTracks { get; set; }
    }
}
