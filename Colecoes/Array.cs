using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CursoCSharp.Colecoes;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[]alunos = new string[5];
            alunos[0] = "Marc";
            alunos[1] = "Fernanda";
            alunos[2] = "Gabriela";
            alunos[3] = "Daniela";
            alunos[4] = "Walfredo";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
                
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            // outra forma de fazer a varredura 

            double media = somatorio / notas.Length;
            Console.WriteLine("");
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine("");
            Console.WriteLine(palavra);
        }
    }
}
