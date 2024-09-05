using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    internal class DesafioAtributos
    {
        int a = 10;
        public static void Executar()
        {
            // Acessando a variável A, cria-se uma instancia da classe para poder acessá-lo, pois ele n é static
            DesafioAtributos desafio = new DesafioAtributos();
            Console.WriteLine(desafio.a);
        }
    }
}
