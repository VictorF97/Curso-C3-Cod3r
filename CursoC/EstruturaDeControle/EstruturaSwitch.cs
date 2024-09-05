using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie o atendimento com nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch(nota)
            {
                case 0:
                    Console.WriteLine("Atendimento péssimo!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Atendimento ruim!");
                    break;
                case 3:
                    Console.WriteLine("Atendimento mediano!");
                    break;
                case 4:
                    Console.WriteLine("Atendimento bom!");
                    break;
                case 5:
                    Console.WriteLine("Atendimento ótimo!");
                    break;
                default:
                    Console.WriteLine("Avaliação Inválida!");
                    break;
            }

            Console.WriteLine("Fim!");
        }
    }
}
