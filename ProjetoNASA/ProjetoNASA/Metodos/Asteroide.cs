using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ProjetoNASA.GetSet;

namespace ProjetoNASA.Metodos
{
    public class Asteroide
    {
        public static async Task<List<GetSetASTEROIDE>> DadosAsteroide ()
        {
            var API_KEY = "";
            var API = $"http://api.nasa.gov/neo/rest/v1/neo/3542519?api_key={API_KEY}";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; NasaAPP/1.0)");
            return await cliente.GetFromJsonAsync<List<GetSetASTEROIDE>>(API) ?? new List<GetSetASTEROIDE>();
        }
    }
}
