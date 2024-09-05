using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno:");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento |= true;     

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToUpper() == "S";

            if(nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
