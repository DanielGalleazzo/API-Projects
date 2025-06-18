using ValidadorDeCep.Metodos;
using System;
using System.IO;
using System.Threading.Tasks;


class Program
{
    static async Task Main()
    {
        Console.WriteLine("Insira o cep");
        string cep = Console.ReadLine();

        try
        {
            var enderecos = await Metodo.BuscarCep(cep);

            Console.WriteLine("CEP: " + enderecos.cep);
            if (enderecos.rua == null)
            {
                Console.WriteLine("Rua não encontrada");
                Console.WriteLine("Bairro: " + enderecos.bairro);
                Console.WriteLine("Região: " + enderecos.regiao);
                Console.WriteLine("Estado: " + enderecos.estado);
            }
            else
            {
                Console.WriteLine("Rua: " + enderecos.rua);
                Console.WriteLine("Bairro: " + enderecos.bairro);
                Console.WriteLine("Região: " + enderecos.regiao);
                Console.WriteLine("Estado: " + enderecos.estado);
            }


                Console.WriteLine("Você quer salvar em um arquivo txt? (Sim/Não)");
            string resposta = Console.ReadLine()?.Trim();

            if (resposta.ToLower() == "sim")
            { 
                string arquivo = "informacoesCEP.txt";
                if (enderecos.rua != null)
                {
                    string conteudo =
                        "Cep: " + enderecos.cep + Environment.NewLine +
                        "Rua: " + enderecos.rua + Environment.NewLine +
                        "Bairro: " + enderecos.bairro + Environment.NewLine +
                        "Região: " + enderecos.regiao + Environment.NewLine +
                        "Estado: " + enderecos.estado;

                    SalvarEmTXT.SalvarTexto(arquivo, conteudo);
                    Console.WriteLine("Arquivo salvo com sucesso.");
                    Console.WriteLine("Salvando em: " + Path.GetFullPath(arquivo));
                }
                else
                {
                    string conteudo2 =
                        "Cep: " + enderecos.cep + Environment.NewLine +
                        "Rua não encontrada" + Environment.NewLine +
                    "Bairro: " + enderecos.bairro + Environment.NewLine +
                        "Região: " + enderecos.regiao + Environment.NewLine +
                        "Estado: " + enderecos.estado;

                    SalvarEmTXT.SalvarTexto(arquivo, conteudo2);
                    Console.WriteLine("Arquivo salvo com sucesso.");
                    Console.WriteLine("Salvando em: " + Path.GetFullPath(arquivo));
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }

   
}
