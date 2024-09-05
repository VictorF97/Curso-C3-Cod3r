using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //Não serão iguais pois verificam os espaços de memoria
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            //Agora é verdadeiro, pois criamos um metodo Equals na classe Produto que
            //verifica os valores
            Console.WriteLine(p1.Equals(p2));


        }
    }
}
