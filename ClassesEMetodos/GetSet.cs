using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto() {
        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {

            //      1 opção 
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            //      2 opção
            //Cilindrada = Math.Abs(cilindrada);

            //      3 opção

            Cilindrada = cilindrada;
        }
    }

}

internal class GetSet {
    public static void Executar() {

        var moto1 = new Moto("Kawasaki  ", "Ninja ZX-6R  ", 636);

        Console.Write(moto1.GetMarca());
        Console.Write(moto1.GetModelo());
        Console.Write(moto1.GetCilindrada());
        Console.WriteLine();



        var moto2 = new Moto();
        moto2.SetMarca("Honda");
        moto2.SetModelo("CG Titan");
        moto2.SetCilindrada(150);


        Console.WriteLine(moto2.GetMarca() + "     " + moto2.GetModelo() + "     " + moto2.GetCilindrada());





    }


}

