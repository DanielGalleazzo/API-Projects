using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;

namespace FindMyRecipe.Metodos
{
    public class StepbyStep
    {
        public static async Task<List<StepbyStep>> StepbySteps(int id)
        {
            string API_KEY = "";
            var url = $"https://api.spoonacular.com/recipes/{id}/analyzedInstructions?apiKey={API_KEY}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var answer = await cliente.GetFromJsonAsync<SBS>(url);
            return answer?.Resultados ?? new List<StepbyStep>(); 
        }
    }
}
