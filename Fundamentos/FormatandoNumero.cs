using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // "F1" =  Arredonda o valor final
            Console.WriteLine(valor.ToString("C")); // "C" (currency)= Moeda corrente do usuário
            Console.WriteLine(valor.ToString("P")); // "P" = Multiplica por 100 e coloca percentual
            Console.WriteLine(valor.ToString("#.##")); // "#.##" = Indica quantas casa decimais você quer utilizar
            
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura)); // "C0"(currency) = Vai mostar a moeda e quantas casas decimais o usuário quer mostrar

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Vai completar X com zeros a esquerda ex.: 0000000256
        }
    }
}
