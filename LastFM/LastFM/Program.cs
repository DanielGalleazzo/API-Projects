
using LastFM;
using LastFM.GetSet;
using System.Net.Http.Json;
using LastFM;



Console.WriteLine("Insira o seu nome de usuário");
string user = Console.ReadLine();
Console.WriteLine("Qual é a quantidade de músicas que você deseja ? ( MAX 200 )");
int quantidade = int.Parse(Console.ReadLine());

var musicas = await Metodo.ObterMusicasRecentesAsync(user, quantidade);


try
{
    foreach (var musica in musicas)
    {
        string artista = musica.Artista?.Nome ?? "Desconhecido";
        string nome = musica.Nome ?? "Sem nome";
        string data = musica.Data?.Texto ?? "(em reprodução agora)";

        Console.WriteLine($"{artista} - {nome} - {data}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Não foi possível. Código do erro: {ex.Message}");
}



