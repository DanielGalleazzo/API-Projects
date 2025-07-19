
using LastFM.GetSet;
using System.Net.Http.Json;



Console.WriteLine("Insira o seu nome de usuário");
string user = Console.ReadLine();
Console.WriteLine("Qual é a quantidade de músicas que você deseja ? ( MAX 200 )");
int quantidade = int.Parse(Console.ReadLine());
string apiKey = "suaChave"; // Insira a sua chave api aqui

var url = $"https://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user={user}&api_key={apiKey}&format=json&limit={quantidade}&page=1";
using var cliente = new HttpClient();
cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; LastFMaPI/1.0)");
var resposta = await cliente.GetFromJsonAsync<Root>(url);

List<Musica> musicas = resposta?.RecentTracks?.Tracks ?? new List<Musica>();

foreach (var musica in musicas)
{
    string artista = musica.Artista?.Nome ?? "Desconhecido";
    string nome = musica.Nome ?? "Sem nome";
    string data = musica.Data?.Texto ?? "(em reprodução agora)";

    Console.WriteLine($"{artista} - {nome} - {data}");
}


/*
 * {
  "recenttracks": {
    "track": [
      {
        "artist": {
          "#text": "Nome do Artista",
          "mbid": "ID da música no MusicBrainz (opcional)"
        },
        "name": "Nome da Faixa",
        "streamable": "0" or "1",
        "mbid": "ID da faixa no MusicBrainz (opcional)",
        "album": {
          "#text": "Nome do Álbum",
          "mbid": "ID do álbum no MusicBrainz (opcional)"
        },
        "url": "https://link-da-musica-no-lastfm",
        "image": [
          {
            "#text": "URL da imagem",
            "size": "small"
          },
          {
            "#text": "URL da imagem",
            "size": "medium"
          },
          {
            "#text": "URL da imagem",
            "size": "large"
          },
          {
            "#text": "URL da imagem",
            "size": "extralarge"
          }
        ],
        "date": {
          "uts": "timestamp Unix",
          "#text": "Data legível"
        },
        "@attr": {
          "nowplaying": "true"
        }
      },
      ...
    ],
    "@attr": {
      "user": "USERNAME",
      "page": "1",
      "perPage": "50",
      "totalPages": "N",
      "total": "X"
    }
  }
}
*/
