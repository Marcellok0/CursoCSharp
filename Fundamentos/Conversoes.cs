using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {//Conversão implícita
            int inteiro = 10;
            double  quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão numérica explicita usando o cache
            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);


            //Conversão entre inteiro e string
            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida : {0}", idadeInteiro);


            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);


            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); //tenta fazer o parse se nao conseguir retorna o valor ZERO (0)
            Console.WriteLine("Resultado: {0}", numero1 );


            //versão otimizada   +
            //                               +
            //                               V
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); //tenta fazer o parse se nao conseguir retorna o valor ZERO (0)
            Console.WriteLine("Resultado: {0}", numero2);
        }
    }
}
