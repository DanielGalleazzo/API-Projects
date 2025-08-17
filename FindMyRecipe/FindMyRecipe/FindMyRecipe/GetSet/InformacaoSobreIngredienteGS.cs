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
        public int Id { get; set; }

        [JsonPropertyName("originalName")]
        public string RealName { get; set; }

        [JsonPropertyName("estimatedCost")]
        public EstimatedCost EstimatedCost { get; set; }
    }
    public class EstimatedCost
    {
        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
