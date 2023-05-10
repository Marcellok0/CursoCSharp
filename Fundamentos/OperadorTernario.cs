using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario // dividido em 3 partes
                                    // 1) expressão, separado pelo ? 2) operando 1 separado pelo :  3) operando 2

    {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = false;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : " Reprovado";

            // ?
            // :

            Console.WriteLine(resultado);
        }
    }
}
