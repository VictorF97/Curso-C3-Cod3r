using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo Proximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); não possui acesso para os atributos
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamiliar);  não possui acesso para os atributos
            //Console.WriteLine(amiga.UsaPhotoshop); não possui acesso para os atributos
        }
    }
}
