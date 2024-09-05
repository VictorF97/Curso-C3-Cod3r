using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.MetodosEFuncoes
{
    internal class Delegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma (double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            //Quando tipo dos parametros a quantidade a ordem e o tipo de retorno forem iguais
            //é possível associar a função que existe ao tipo delegate dentro de uma variavel
            Soma soma1 = MinhaSoma;
            Console.WriteLine(soma1(1,2));

            ImprimirSoma imprimir = MeuImprimirSoma;
            imprimir(9,6);

            //sempre o ultimo é o tipo de retorno
            Func<double, double, double> operacao3 = MinhaSoma;
            Console.WriteLine(operacao3(3.5, 4.5));

            //passa os parametros apenas
            Action<double, double> operacao4 = MeuImprimirSoma;
            operacao4(10.5, 8.0);
        }
    }
}
