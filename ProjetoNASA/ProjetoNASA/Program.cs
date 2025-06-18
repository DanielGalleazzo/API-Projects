using NASA_API;

using NASA_API;

Console.WriteLine("Você quer ver fotos que a NASA capturou ?");
string resposta = Console.ReadLine();

if (resposta.ToLower() == "sim")
{
    var fotos = await ImageOfTheDay.PhotoOfTheDay();
    foreach (var foto in fotos)
    {
        Console.WriteLine("Titulo: " + foto.title);
        Console.WriteLine("Data da foto: " + foto.date);
        Console.WriteLine("URL da foto: " + foto.url);
    }
}
else
{
    Console.WriteLine("Tudo bem! Em breve haverá mais opções, espero que alguma te agrade no futuro");
}
