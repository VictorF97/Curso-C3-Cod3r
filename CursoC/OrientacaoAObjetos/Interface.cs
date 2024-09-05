using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.OrientacaoAObjetos
{
    interface Teste
    {
        bool Bla(string a);
    }

    //os métodos de uma interface são sempre abstratos
    interface OperacaoBinaria
    {
        //por padrão os métodos são publicos
        int Operacao(int a, int b);
    }

    public class Soma : OperacaoBinaria, Teste
    {
        public bool Bla(string teste)
        {
            return true;
        }

        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    public class Divisao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a / b;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Divisao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach(var operacao in operacoes)
            {
                resultado += $"A operação {operacao.GetType().Name} = {operacao.Operacao(a,b)} \n";
            }

            return resultado;
        }
    }

    public class Interface
    {
        public static void Executar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);

        }
    }
}
