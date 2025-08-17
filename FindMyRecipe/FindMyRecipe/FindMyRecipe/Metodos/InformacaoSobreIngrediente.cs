using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;
using System.Net.Http.Json;

namespace FindMyRecipe.Metodos
{
    public class InformacaoSobreIngrediente
    {
        public static async Task <List<InformacaoSobreIngredienteGS>> InformacaoIngrediente(int id)
        {
            string api = "";
            var link = $"https://api.spoonacular.com/food/ingredients/{id}/information?apiKey={api}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var answer = await cliente.GetFromJsonAsync<InformacaoSobreIngredienteGS>(link);
            return answer != null ? new List<InformacaoSobreIngredienteGS> { answer } : new List<InformacaoSobreIngredienteGS>();
        }
    }
}
