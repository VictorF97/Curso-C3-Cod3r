using System;
using CursoC.Fundamentos;
using CursoC.EstruturaDeControle;
using CursoC.ClassesEMetodos;
using CursoC.Colecoes;
using CursoC.OrientacaoAObjetos;
using CursoC.MetodosEFuncoes;
using CursoC.ExplorandoApi;
using CursoCSharp.Api;

namespace CursoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},

                //Estrutura de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Usando membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estático - Classes e Métodos", MetodoEstatico.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributos - Classes e Métodos", DesafioAtributos.Executar },
                {"Parametros e variáveis - Classes e Métodos", ParametrosVariaveis.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Getters e Setters - Classes e Métodos", GettersESetters.Executar },
                {"Parametros por referencia - Classes e Métodos", ParametrosPorRef.Executar },
                {"Parametros Padrão - Classes e Métodos", ParametrosPadrao.Executar },

                //Coleções
                {"Arrays - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", UsandoList.Executar },
                {"ArrayList - Coleções", UsandoArrayList.Executar },
                {"Set - Coleções", UsandoSet.Executar },
                {"Queue - Coleções", UsandoQueue.Executar },
                {"Igualdade (Equals e GetHashCode)  - Coleções", Igualdade.Executar },
                {"Stack  - Coleções", UsandoStack.Executar },
                {"Dictionary  - Coleções", UsandoDictionary.Executar },

                //Orientação a Objeto
                {"Herança - Orientação a Objetos", Heranca.Executar },
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar },
                {"Encapsulamento - Orientação a Objetos", OrientacaoAObjetos.Encapsulamento.Executar },
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar },
                {"Abstract - Orientação a Objetos", Abstract.Executar },
                {"Interface - Orientação a Objetos", Interface.Executar },
                {"Classe Sealed - Orientação a Objetos", Sealed.Executar },

                //Métodos e Funções
                {"Expressão Lambda - Métodos e Funções", Lambda.Executar },
                {"Lambda com Delegate - Métodos e Funções", LambdaDelegate.Executar },
                {"Usando Delegate - Métodos e Funções", MetodosEFuncoes.Delegate.Executar },
                {"Delegate com Funções Anônimas - Métodos e Funções", DelegateFuncAnon.Executar },
                {"Delegate como Parâmetro - Métodos e Funções", DelegateParametro.Executar },
                {"Métodos de Extensões - Métodos e Funções", MetodosDeExtensao.Executar },

                //Exceções e Tratamento de Erro
                {"Exceção - Exceções e Tratamento de Erro", Excecoes.Excecoes.Executar },

                //Explorando API
                {"Arquivo Escrevendo Dados - Explorando API", EscrevendoArquivo.Executar },
                {"Arquivo Lendo Dados - Explorando API", LendoArquivos.Executar },
                {"Usando FileInfo - Explorando API", UsandoFileInfo.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}