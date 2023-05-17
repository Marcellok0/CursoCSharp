﻿using System;
using Encapsulamento;

namespace CursoCSharp.OO
{

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }

    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");


            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    internal class Encapsulamento
    {public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos(); 
            Console.WriteLine("");

            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine("");
            new AmigoProximo().MeusAcessos();
            Console.WriteLine("");
            new FilhoNaoReconhecido() .MeusAcessos();
            Console.WriteLine("");
            new AmigoDistante().MeusAcessos();
        }
    }
}
