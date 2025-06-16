using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ValidadorDeCep.GetSet;

namespace ValidadorDeCep.Metodos
{
    public class Metodo
    {
        public static async Task<Endereco?> BuscarCep(string cep)
        {
            var API = $"https://viacep.com.br/ws/{Uri.EscapeDataString(cep)}/json/";
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; CEP/1.0)");

            var endereco = await cliente.GetFromJsonAsync<Endereco>(API);
            return endereco?.cep == null ? null : endereco;
        }
    }
}