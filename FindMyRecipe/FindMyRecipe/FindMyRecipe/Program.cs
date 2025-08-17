using FindMyRecipe.Metodos;
/*
Console.WriteLine("1 - Ver receitas com um ingrediente base:");
Console.WriteLine("2 - Ver detalhes através do id de uma receita");
Console.WriteLine("3 - Informações nutricionais sobre um prato");
int switchcase = int.Parse(Console.ReadLine());
*/


/*
switch (switchcase)
{
    case 1:
        Console.WriteLine("Write the main ingredient of the recipe");
        string mainItem = Console.ReadLine();
        Console.WriteLine("How many suggestions do you wanna ?");
        int amountSuggestions = int.Parse(Console.ReadLine());

        var receitaLista = await BuscaPorIngrediente.BuscaPorIngredientes(mainItem, amountSuggestions);

        foreach (var receitaList in receitaLista)
        {
            Console.WriteLine("id da receita: " + receitaList.Id);
            Console.WriteLine("Nome da receita: " + receitaList.Title);
            Console.WriteLine("");
        }
        break;

    case 2:
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
            if (recipe.Vegan == false)
            {
                Console.WriteLine("Não é vegano");
            }
            else
            {
                Console.WriteLine("É vegano");
            }
        }
        break;

    case 3:
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
        break;

        case 4:
        Console.WriteLine("Qual o alimento base ? ex: meal, carrot, fish, etc");
        string alimentoBase = Console.ReadLine();
        Console.WriteLine("Quantos resultados você quer receber ?");
        int resultados = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a quantidade mínima de proteína que você deseja ?");
        int minProteina = int.Parse(Console.ReadLine());
        Console.WriteLine("Você quer o mínimo ou o máximo ?");
        string minimoMaximo = Console.ReadLine(); // "min" ou "max"


        var nutrienteMinimo = await NutrienteMinimo.NutrienteMinMax(alimentoBase, resultados, minProteina, minimoMaximo);

        foreach (var Nutrientes in nutrienteMinimo)
        {
            try
            {
                Console.WriteLine("Id do prato ou produto");
                Console.WriteLine(Nutrientes.Id);
                Console.WriteLine("Titulo do prato ou produto");
                Console.WriteLine(Nutrientes.Title);
            }
            catch (Exception ex)
            {
                if (Nutrientes.Id == 0)
                {
                    Console.WriteLine("Nenhum produto encontrado com os critérios especificados.");
                    continue;
                }
                Console.WriteLine("Ocorreu um erro ao processar os dados: " + ex.Message);
            }

        }
        break;
}
*/
/*
Console.WriteLine("Qual a sua pergunta ?"); // o input deve ser feito em inglês
string pergunta = Console.ReadLine();

var resposta = await Question_Answer.QuestionAnswer(pergunta);

foreach (var item in resposta)
{
    Console.WriteLine("Resposta: " + item.Answer);
}
*/

Console.WriteLine("Qual o id do ingrediente que você quer saber ?");
int IDingrediente = int.Parse(Console.ReadLine());

var informacaoIngrediente = await InformacaoSobreIngrediente.InformacaoIngrediente(IDingrediente);


    Console.WriteLine("Nome do ingrediente:" + informacaoIngrediente.RealName); // 57810
    Console.WriteLine("Estimativa do preço do produto:" + informacaoIngrediente.EstimatedCost);





