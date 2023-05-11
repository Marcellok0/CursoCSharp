using System;
using System.Collections.Generic;
using System.Collections;


namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {public static void Executar()
        {
            var fila = new Queue<string>();  // Queue -  Fila

            fila.Enqueue ("Fulano");
            fila.Enqueue ("Sicrano");
            fila.Enqueue ("Beltrano");
            fila.Enqueue ("Cacilds");

            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());  // Peek -  Pega um elemento da fila sem removê-lo.

            Console.WriteLine(fila.Dequeue());  // Dequeue  - Desenfilera o elemento da fila  
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
