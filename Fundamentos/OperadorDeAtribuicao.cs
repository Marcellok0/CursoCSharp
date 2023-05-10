using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorDeAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7; // neste caso houve a substituição do valor anterior, ou seja 3 passou a ser 7.
            num1 += 10;  //num1 = num1 + 10 (neste exemplo a variável acrescenta + 10 ficando assim: 17 ).
            num1 -= 3;  // num1 = num1 - 3 (neste exemplo a variável diminui -3 ficando assim: 4 ).
            num1 *= 5; //num 1 = num1 * 5 (neste exemplo a variável será multiplicada por 5 ficando assim: 35 ).
            num1 /= 2; //num 1 = num1 / 2 (neste exemplo a variável será dividida por 2 ficando assim: 1).

            Console.WriteLine("Resultados de todas as operações: {0}", num1);

            int a = 1;
            int b = a;

            a++;  // a= a + 1  Operador unário
            b--;   //b = b - 1  Operador unário
        }
    }
}
