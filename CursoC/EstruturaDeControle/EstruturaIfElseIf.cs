using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9)
            {
                Console.WriteLine("Quadro de honra!");
            } else if(nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado!");
            } else if(nota >= 5 && nota < 7)
            {
                Console.WriteLine("Aluno de recuperação");
            } else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}