using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Victor";
            pessoa.Idade = 26;

            //Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");

            pessoa.ApresentarConsole();
            pessoa.Zerar();
            pessoa.ApresentarConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Isabelly";
            fulano.Idade = 22;

            var apresentarNoConsole = fulano.Apresentar();
        }
    }
}
