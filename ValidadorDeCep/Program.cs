using ValidadorDeCep.Metodos;

Console.WriteLine("Insira o cep");
string cep = Console.ReadLine();
var enderecos = await Metodo.BuscarCep(cep);
try
{
        Console.WriteLine("CEP: " + enderecos.cep);
        if (enderecos.rua == null)
        {
            Console.WriteLine("Rua não encontrada");
        }
        else
        {
            Console.WriteLine("Rua: " + enderecos.rua);
        }
        Console.WriteLine("Bairro: " + enderecos.bairro);
        Console.WriteLine("Região: " + enderecos.regiao);
        Console.WriteLine("Estado: " + enderecos.estado);
    
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}