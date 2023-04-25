using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
              string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    // var corAnterior = Console.BackgroundColor;
                    //Console.BackgroundColor = ConsoleColor.DarkGreen;
                    //Console.WriteLine("Número encontrado em {0} tentativas. ", tentativas);
                    //Console.BackgroundColor = corAnterior;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;

                    // Console.Write em vez de Console.WriteLine para não
                    // pintar a linha de baixo
                    Console.Write("Numero encontrado em {0} tentativas", tentativas);

                    // Console.ResetColor() é chamado antes de imprimir a nova linha
                    // para evitar que a linha de baixo seja pintada
                    Console.ResetColor();

                    // Console.WriteLine() apenas imprime uma nova linha
                    // novamente com a cor original do console
                    Console.WriteLine();


                    // Mesma coisa que foi feita para a frase anterior
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write("O número era: {0}", numeroSecreto);

                    Console.ResetColor();
                    Console.WriteLine();



                } else if (palpite > numeroSecreto){
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("tentativas restantes: {0}", tentativasRestantes);
                } else  {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}",tentativasRestantes);
                }
                }
            }
        }
    }

