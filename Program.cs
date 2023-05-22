using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
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
                {"Get Set - Classes e Metodos ", GetSet.Executar},
                {"Props - Classes e Metodos ", Props.Executar},
                {"Readonly - Classes e Metodos ", Readonly.Executar},
                {"Enum - Classes e Metodos ", ExemploEnum.Executar},
                {"Struct - Classes e Metodos ", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos ", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Metodos ", ValorVsReferencia.Executar},
                {"Parêmetros por Referência - Classes e Metodos ", ParametrosPorReferencia.Executar},
                {"Parêmetro Padrão - Classes e Metodos ", ParametroPadrao.Executar},
                
                //  Coleções
                {"Array - Coleções ", Colecoes.Array.Executar},
                {"List - Coleções ", ColecoesList.Executar},
                {"Array List - Coleções ", ColecoesArrayList.Executar},
                {"Set - Coleções ", ColecoesSet.Executar},
                {"Queue - Coleções ", ColecoesQueue.Executar},
                {"Igualdade - Coleções ", Igualdade.Executar},
                {"Dictionary- Coleções ", ColecoesDictionary.Executar},
                                
                //  OO
                {"Heranca - OO ", Heranca.Executar},
                {"Construtor This - OO ", ConstrutorThis.Executar},
                {"Encapsulamento - OO ", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO ", Polimorfismo.Executar},
                {"Abstract - OO ", Abstract.Executar},
                {"Interface - OO ", Interface.Executar},
                {"Sealed- OO ", Sealed.Executar},

                //Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções ",ExemploLambda.Executar},
                {"Lambda como Delegates - Métodos & Funções ",LambdasDelegates.Executar},
                {"Usando Delegates - Métodos & Funções ",UsandoDelegates.Executar},
                {"Delegates Como Funções Anonimas - Métodos & Funções ", DelegateFuncAnonima.Executar},
                {"Delegates Como Parametros - Métodos & Funções ", DelegatesComoParametros.Executar},
                {"Métodos de Extenção - Métodos & Funções ", MetodosDeExtensao.Executar},

                //  Exceções
                {"Primeira Exceção - Exceções ", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções ", ExcecoesPersonalizadas.Executar},
                
                //  Api
                {"Primeiro Arquivo - Usando Api ", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando Api ", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                { "Diretórios - Usando API", Diretorios.Executar},
                { "Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - Usando API", ExemploPath.Executar},
                { "Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                { "Exemplo Timespan - Usando API", ExemploTimeSpan.Executar},

                // Tópicos Avançados
                //{ "LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                //{ "LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                //{ "Nullables - Tópicos Avançados", Nullables.Executar},
                //{ "Dynamics - Tópicos Avançados", Dynamics.Executar},
                //{ "Genéricos - Tópicos Avançados", Genericos.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}