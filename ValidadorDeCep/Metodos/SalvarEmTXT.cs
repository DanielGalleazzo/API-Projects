using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeCep.Metodos
{
    public class SalvarEmTXT
    {
        public static void SalvarTexto(string arquivo, string conteudo)
        {
            File.WriteAllText(arquivo, conteudo);
        }
    }
}
