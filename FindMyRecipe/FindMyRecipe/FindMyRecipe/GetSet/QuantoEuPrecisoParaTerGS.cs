using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FindMyRecipe.GetSet
{
    public class QuantoEuPrecisoParaTerGS
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

    }
    public class QuantoEuPrecisoParaTer
    {
        [JsonPropertyName("targetAmount")]
        public QuantoEuPrecisoParaTerGS TargetAmount { get; set; }
    }
}


/*
 * opções disponíveis:
 * Parameter 'nutrient' must be one of the following: alcohol, alcohol_volume, sugar_alcohol,
 * caffeine, lycopene, copper, energy, calcium, carbohydrates, net_carbs, 
 * choline, cholesterol, total_fat, fluoride, trans_fat, saturated_fat, monounsaturated_fat,
 * polyunsaturated_fat, dietary_fiber, folic_acid,] folic_acid, iodine,
 * iron, magnesium, manganese, niacin, vitamin_b5, phosphorus,
 * potassium, protein, riboflavin, selenium, sodium, thiamin, vitamin_a, vitamin_b6, vitamin_b12, vitamin_c,
 * vitamin_d, vitamin_e, vitamin_k, sugar, and zinc"
 * 
  */