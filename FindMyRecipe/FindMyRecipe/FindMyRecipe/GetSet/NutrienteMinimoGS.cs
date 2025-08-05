using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FindMyRecipe.GetSet
{
    public class NutrienteMinimoGS
    {
        
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
    public class Nutrientes
    {
        [JsonPropertyName("products")]
        public NutrienteMinimoGS Products { get; set; }
    }
}
