using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FindMyRecipe.GetSet
{
    public class InformacaoSobreIngredienteGS
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("originalName")]
        public string real_name { get; set; }

        [JsonPropertyName("estimatedCost")]
        public double value { get; set; }
    }
}
