using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.MetodosEFuncoes
{
    internal class Lambda
    {
        public static void Executar()
        {
            //função Lambda - Função anônima
            //Action é um função VOID
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda Com C#");
            };

            algoNoConsole();

            //Func é uma função com RETURN
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //Função normal com lambda
            //Func<int, string> conversorHexa = (numero) =>
            //{
            //    return numero.ToString("X");
            //};

            //Recebe um inteiro e retorna uma string
            //Função reduzida com lambda onde inplicitamente há um RETURN
            Func<int, string> conversorHexaDecimal = numero => numero.ToString("X");
            Console.WriteLine(conversorHexaDecimal(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));


        }
    }
}
