using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;

namespace FindMyRecipe.Metodos
{
    public class Detalhes
    {
        public static async Task<List<DetalhesDeUmaReceita>> DetalhesReceita(int id)
        {
            string api = " ";
            var link = $"https://api.spoonacular.com/recipes/{id}/information?includeNutrition=true&apiKey={api}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var answer = await cliente.GetFromJsonAsync<DetalhesDeUmaReceita>(link);
            return answer != null ? new List<DetalhesDeUmaReceita> { answer } : new List<DetalhesDeUmaReceita>();
        }
    }
}
