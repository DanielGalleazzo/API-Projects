using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastFM.GetSet;
using System.Net.Http.Json;

namespace LastFM
{
    public  class Metodo
    {
        public static async Task<List<Musica>> ObterMusicasRecentesAsync(string usuario, int quantidade)
        {
            string apiKey = "api"; // Insira a sua chave api aqui
            var url = $"https://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user={usuario}&api_key={apiKey}&format=json&limit={quantidade}&page=1";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; LastFMaPI/1.0)");
            var resposta = await cliente.GetFromJsonAsync<Root>(url);
            return resposta?.RecentTracks?.Tracks ?? new List<Musica>();
        }
    }
}
