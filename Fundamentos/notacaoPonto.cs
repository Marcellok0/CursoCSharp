using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class notacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

                        Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
 