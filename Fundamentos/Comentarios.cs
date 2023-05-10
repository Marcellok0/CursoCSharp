using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Comentarios {
        public static void Executar() {
            //Cuidados com comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor");

            /*
             * comentario de 
             * varias linhas 
             */


            /// <summary>
            /// <see cref=""/>
            /// <param name="a"> </param>
            /// </summary>
            Console.WriteLine("O C# tem o XML Comments");
        }
    }
}
