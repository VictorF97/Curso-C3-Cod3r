using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7;

            if(nota >= 7)
            {
                Console.WriteLine("Aprovado!");
            } else
            {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
