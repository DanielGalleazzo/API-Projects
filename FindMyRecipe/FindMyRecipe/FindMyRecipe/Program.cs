using FindMyRecipe.Metodos;



Console.WriteLine("Insira o nome da receita que você deseja fazer: ( exemplo: pasta, meal, carrot");
string receita = Console.ReadLine();
Console.WriteLine("Insira a quantidade de receitas que você quer receber");
int quantidade =  int.Parse(Console.ReadLine());


var receitaLista = await BuscaPorIngrediente.BuscaPorIngredientes(receita, quantidade);

foreach (var receitaList in receitaLista)
{
    Console.WriteLine("id da receita: " + receitaList.Id);
    Console.WriteLine("Nome da receita: " + receitaList.Title);
}