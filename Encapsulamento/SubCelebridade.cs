using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Atributos que podem ser acessados
        //Todos
        public string InfoPublica = "Tenho instagram";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo Projeto
        internal long NumeroCelular = 5511984845151;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe ou herança ou mesmo projeto
        private protected string SegredoFamiliar = "Blá Blá Blá";

        //private é padrão
        bool UsaPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridades...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamiliar);
            Console.WriteLine(UsaPhotoshop);

        }
    }
}
