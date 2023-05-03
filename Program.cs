using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
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
                {"Operadores Unários - Fundamentos ",  OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos ",  OperadorTernario.Executar},
                 
                // Estruturas de Controle
                {"Estruturas If - Estruturas de Controle ",  EstruturaIf.Executar},
                {"Estruturas If/Else - Estruturas de Controle ",  EstruturaIfElse.Executar},
                {"Estruturas If/Else/If - Estruturas de Controle ",  EstruturaIfElseIf.Executar},
                {"Estruturas Switch - Estruturas de Controle ",  EstruturaSwitch.Executar},
                {"Estruturas While - Estruturas de Controle ",  EstruturaWhile.Executar},
                {"Estruturas Do/While - Estruturas de Controle ",  EstruturaDoWhile.Executar},
                {"Estruturas For - Estruturas de Controle ",  EstruturaFor.Executar},
                {"Estruturas ForEach - Estruturas de Controle ",  EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle ",  UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle ",  UsandoContinue.Executar},

                // Classes e Metodos
                {"Membros - Classes e Métodos ",  Membros.Executar},
                {"Construtores - Classes e Métodos ",  Construtores.Executar},
                {"Metodos Com Retorno - Classes e Métodos ",  MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Metodos ",  MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos ", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos ", DesafioAtributo.Executar},
                {"Parametros - Classes e Metodos ", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos ", ParametrosNomeados.Executar},


            });
            central.SelecionarEExecutar();
        }
    }
}