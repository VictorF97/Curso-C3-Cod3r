using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    internal class ParametrosVariaveis
    {
        //O params permite passar parametros variaveis, ou seja, agrupa varios valores dentro dela
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("Olá, {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Victor", "Eduardo", "Paulo");
        }
    }
}
