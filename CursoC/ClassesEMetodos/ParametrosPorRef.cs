using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    internal class ParametrosPorRef
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }


        public static void AlterarOut(out int numero, out int numero1)
        {
            numero = 0;
            numero1 = 0;
            numero = numero + 15;
            numero1 = numero1 + 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b}, {c}");
        }
    }
}
