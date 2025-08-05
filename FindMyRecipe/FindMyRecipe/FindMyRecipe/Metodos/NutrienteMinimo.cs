using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;
using System.Net.Http.Json;

namespace FindMyRecipe.Metodos
{
    public class NutrienteMinimo
    {
        public static async Task <List<NutrienteMinimoGS>> NutrienteMinMax(string alimento,int results, int minimo)
        {
            string api = "";
            var link = $"https://api.spoonacular.com/food/products/search?query={alimento}&number={results}&minProtein={minimo}&apiKey={api}";
            using var cliente = new HttpClient();
            var answer = await cliente.GetFromJsonAsync<NutrienteMinimoGS>(link);
            return answer != null ? new List<NutrienteMinimoGS> { answer } : new List<NutrienteMinimoGS>();

        }
    }
}
