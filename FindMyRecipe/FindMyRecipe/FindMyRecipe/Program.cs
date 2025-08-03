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
Console.WriteLine("Do you wanna see the step-by-step of a specify recipe ?");
string answerStep =  Console.ReadLine();

if (answerStep == "yes")
{
    Console.WriteLine("What's the id of the recipe ?");
    int idAnswer = int.Parse(Console.ReadLine()); // 57810 Choucroute Garni testar com esse exemplo


}