using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjetoNASA.GetSet
{
    public class GetSetASTEROIDE
    {
        [JsonPropertyName("neo_reference_id")]
        public int neo_reference_id { get; set; }
        [JsonPropertyName("is_potentially_hazardous_asteroid")]
        public bool is_potentially_hazardous_asteroid { get; set; }
    }

}
