using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    internal class ParametrosPadrao
    {
        //Se os parametros não forem REF ou OUT, podem receberem valores padrões
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b:7));
        }
    }
}
