using ValidadorDeCep.GetSet;
using ValidadorDeCep.Metodos;

Console.WriteLine("Insira o cep");
string cep = Console.ReadLine();
var enderecos = await Metodo.BuscarCep(cep);

Console.WriteLine($"CEP: {enderecos.cep}");
Console.WriteLine($"Logradouro: {enderecos.logradouro}");
Console.WriteLine($"Bairro: {enderecos.bairro}");
Console.WriteLine($"Cidade: {enderecos.cidade}");
Console.WriteLine($"Estado: {enderecos.estado}");