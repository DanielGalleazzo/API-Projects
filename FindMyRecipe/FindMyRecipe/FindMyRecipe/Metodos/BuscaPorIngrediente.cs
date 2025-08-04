using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;

namespace FindMyRecipe.Metodos
{
    public class BuscaPorIngrediente
    {
        public static async Task <List<BuscaPorIngredienteGS>> BuscaPorIngredientes(string recipe, int quantity)
        {
            string API_KEY = "";
            var url = $"https://api.spoonacular.com/recipes/complexSearch?query={recipe}&number={quantity}&apiKey={API_KEY}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var resposta = await cliente.GetFromJsonAsync<Root>(url);

            return resposta?.Results ?? new List<BuscaPorIngredienteGS>();
        }
    }
}
