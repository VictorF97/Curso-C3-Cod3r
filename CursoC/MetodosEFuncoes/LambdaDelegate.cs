using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoC.MetodosEFuncoes
{
    //DELEGATE - define um tipo que armazena o tipo de uma função
    delegate double Operacao(double x, double y);

    internal class LambdaDelegate
    {
        public static void Executar()
        {
            //parametros sao double, definido no delegate
            Operacao soma = (x, y) => x + y;
            Console.WriteLine(soma(5,1));

            Operacao subtracao = (x, y) => x - y;
            Console.WriteLine(subtracao(10,5));

            Operacao multiplicacao = (x, y) => x * y;
            Console.WriteLine(multiplicacao(4,7));
        }
    }
}
