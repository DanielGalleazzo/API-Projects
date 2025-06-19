using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ProjetoNASA.GetSet;

namespace NASA_API
{
    public class ImageOfTheDay
    {
        public static async Task<List<GetSetDayPhoto>> PhotoOfTheDay()
        {
            var API_KEY = "";
            var API = $"https://api.nasa.gov/planetary/apod?api_key={API_KEY}&count=3";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; NasaAPP/1.0)");
            return await cliente.GetFromJsonAsync<List<GetSetDayPhoto>>(API) ?? new List<GetSetDayPhoto>();

        }
    }
}
