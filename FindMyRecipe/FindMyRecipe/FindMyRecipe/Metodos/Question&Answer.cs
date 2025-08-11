using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMyRecipe.GetSet;
using System.Net.Http.Json;

namespace FindMyRecipe.Metodos
{
    public class Question_Answer
    {
        public static async Task<List<GetSet.Question_Answer>> QuestionAnswer(string question)
        {
            string apiKey = "";
            string link = $"https://api.spoonacular.com/recipes/quickAnswer?q={question}&apiKey={apiKey}";
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; FindMyRecipe/1.0)");
            var answer = await client.GetFromJsonAsync<GetSet.Question_Answer>(link);
            return answer != null ? new List<GetSet.Question_Answer> { answer } : new List<GetSet.Question_Answer>();
        }
    }
}
