using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FindMyRecipe.GetSet
{
    public class DetalhesDeUmaReceitaGS
    {
        [JsonPropertyName("servings")]
        public int Servings { get; set; }

        [JsonPropertyName("readyInMinutes")]
        public int TimeToBeDone { get; set; }

        [JsonPropertyName("vegan")]
        public bool Vegan { get; set; }
    }
  
}
