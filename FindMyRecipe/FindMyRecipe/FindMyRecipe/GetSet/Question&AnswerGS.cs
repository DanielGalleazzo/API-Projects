using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;




namespace FindMyRecipe.GetSet
{
    public class Question_Answer
    {
        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}
