using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //inverte o sinal do operando.
            Console.WriteLine(!booleano); //negação lógica (inverte a variável, se positivo vira negativo).

            numero1++; // acrescenta +1 ao valor
            Console.WriteLine(numero1);

            --numero1; // subtrai -1 ao valor
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); //++ após a variável ,vai fazer a atribuição depois da comparação; o resultado sera true neste caso.


        }
    }
}
