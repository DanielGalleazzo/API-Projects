using FindMyRecipe.Metodos;

/*
Console.WriteLine("Write the main ingredient of the recipe");
string mainItem = Console.ReadLine();
Console.WriteLine("How many suggestions do you wanna ?");
int amountSuggestions =  int.Parse(Console.ReadLine());

var receitaLista = await BuscaPorIngrediente.BuscaPorIngredientes(mainItem, amountSuggestions);

foreach (var receitaList in receitaLista)
{
    Console.WriteLine("id da receita: " + receitaList.Id);
    Console.WriteLine("Nome da receita: " + receitaList.Title);
    Console.WriteLine("");
}
Console.WriteLine("Here is the details of a specify recipe");

Console.WriteLine("What's the id of the recipe ?");
int idAnswer = int.Parse(Console.ReadLine()); // 57810 Choucroute Garni. testar com esse exemplo
Console.WriteLine($"Ok, here is the details of the recipe: {idAnswer}");

    var details = await Detalhes.DetalhesReceita(idAnswer);

    foreach (var recipe in details)
    {
        Console.WriteLine($"Serve quantas pessoas ?");
        Console.WriteLine(recipe.Servings + " pessoas");
        Console.WriteLine("Quanto tempo leva para ficar pronto ?");
        Console.WriteLine(recipe.TimeToBeDone + " minutos");
        Console.WriteLine("É vegano ?");
        if(recipe.Vegan == false)
        {
        Console.WriteLine("Não é vegano");
        }
        else
        {
        Console.WriteLine("É vegano");
        }
        
}

*/

Console.WriteLine("Qual o id do prato que você quer ter as informações ?");
int id = int.Parse(Console.ReadLine());
Console.WriteLine("Qual nutriente você quer saber ?");
string nutriente = Console.ReadLine();
Console.WriteLine("Qual é o objetivo ?");
int objetivo = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a unidade que você quer saber ?  oz / g");
var unidade = Console.ReadLine();




var informacoesLista = await QuantoEuPrecisoParaTer.QuantoPreciso(nutriente, id, objetivo, unidade);

foreach (var informacoesListaNutriente in informacoesLista)
{
    Console.WriteLine("Quantidade: " + informacoesListaNutriente.Amount);
    Console.WriteLine("Unidade: " + informacoesListaNutriente.Unit);
}