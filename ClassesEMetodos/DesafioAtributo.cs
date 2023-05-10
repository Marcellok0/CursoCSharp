using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;    //Atributo que pertence a uma instância
        public static void Executar() {// acessar a variavel 'a' dentro do método Executar


            //Precisa criar uma intancia / atribuir a uma variavel e acessar op atributo através da instância 
            DesafioAtributo b = new DesafioAtributo();
            Console.WriteLine(b.a);
        }
    }
}
