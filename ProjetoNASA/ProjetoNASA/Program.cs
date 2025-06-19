using NASA_API;

using NASA_API;
using ProjetoNASA.Metodos;

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

Console.WriteLine("Você quer ver dados sobre um asteroide ?");
string resposta2 =  Console.ReadLine();

if (resposta2.ToLower() == "sim")
{
    var asteroides = await Asteroide.DadosAsteroide();
    foreach (var asteroide in asteroides )
    {
        Console.WriteLine("Titulo: " + asteroide.neo_reference_id);
        Console.WriteLine("Data da foto: " + asteroide.is_potentially_hazardous_asteroid);
        
    }
}
else
{
    Console.WriteLine("Tudo bem! Em breve haverá mais opções, espero que alguma te agrade no futuro");
}