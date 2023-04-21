using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos ",  Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos ",  VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos ",  Inferencia.Executar},
                {"Interpolação - Fundamentos ",  Interpolacao.Executar},
                {"Notação Ponto - Fundamentos ",  notacaoPonto.Executar},
                {"Lendo Dados - Fundamentos ",  LendoDados.Executar},
                {"Formatando Número - Fundamentos ",  FormatandoNumero.Executar},
                {"Conversões - Fundamentos ",  Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos ",  OperadoresAritimeticos.Executar},
                {"Operadores Relacionáis - Fundamentos ",  OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos ",  OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos ",  OperadorDeAtribuicao.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}