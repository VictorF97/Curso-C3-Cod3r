using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;            
        }

        public int Subtrair (int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a) 
        {
            memoria += a;
            //retorna o objeto da CalculadoraCadeia
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }

    }

    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum calculadora = new CalculadoraComum();

            var resultado = calculadora.Somar(1, 1);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadora.Subtrair(1,1));
            Console.WriteLine(calculadora.Multiplicar(2,2));
            Console.WriteLine(calculadora.Dividir(8,2));

            CalculadoraCadeia calculadora2 = new CalculadoraCadeia();
            calculadora2.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadora2.Somar(4).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
