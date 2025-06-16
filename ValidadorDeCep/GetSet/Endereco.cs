using System;
using Newtonsoft.Json;

namespace ValidadorDeCep.GetSet
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string cep { get; set; }

        [JsonProperty("logradouro")]
        public string logradouro { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("localidade")]
        public string cidade { get; set; }

        [JsonProperty("estado")]
        public string estado { get; set; }
    }
}
