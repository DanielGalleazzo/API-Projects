using FindMyRecipe.Metodos;


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
int idAnswer = int.Parse(Console.ReadLine()); // 57810 Choucroute Garni testar com esse exemplo
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

