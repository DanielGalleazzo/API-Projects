using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FindMyRecipe.GetSet
{
    public class StepByStep
    {
        [JsonPropertyName("steps")]
        public string step { get; set; }
    }
    public class SBS
    {
        public List<StepByStep> Resultados { get; set; }
    }
}
