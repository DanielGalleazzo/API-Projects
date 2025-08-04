using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;

namespace FindMyRecipe.Metodos
{
    public class QuantoEuPrecisoParaTer
    {
        public static async Task<List<QuantoEuPrecisoParaTerGS>> QuantoPreciso(string nutrient, int id, int target, string unit)
        {
            string api = "";
            var link = $"https://api.spoonacular.com/food/ingredients/{id}/amount?nutrient={nutrient}&target={target}&unit={unit}&apiKey={api}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var answer = await cliente.GetFromJsonAsync<QuantoEuPrecisoParaTerGS>(link);
            return answer != null ? new List<QuantoEuPrecisoParaTerGS> { answer } : new List<QuantoEuPrecisoParaTerGS>();
        }



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