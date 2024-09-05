using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int num2)
        {
            return num + num2;
        }

        public static double Subtracao(this double num, double num2)
        {
            return num - num2;
        }

        public static int Multiplicacao(this int num, int num2)
        {
            return num * num2;
        }
    }

    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroReal = 5.5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroReal.Subtracao(4));
            Console.WriteLine(numero.Multiplicacao(10));

            //passando valores literais
            Console.WriteLine(3.Soma(8));
            Console.WriteLine(7.5.Subtracao(7));
            Console.WriteLine(1.Multiplicacao(1));
        }
    }
}
