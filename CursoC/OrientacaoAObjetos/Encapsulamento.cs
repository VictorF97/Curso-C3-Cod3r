using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoC.OrientacaoAObjetos
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); não possui acesso para os atributos
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamiliar); não possui acesso para os atributos
            //Console.WriteLine(UsaPhotoshop); não possui acesso para os atributos
        }
    }

    class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante...");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);  não possui acesso para os atributos
            //Console.WriteLine(amigo.NumeroCelular); não possui acesso para os atributos
            //Console.WriteLine(amigo.JeitoDeFalar); não possui acesso para os atributos
            //Console.WriteLine(amigo.SegredoFamiliar); não possui acesso para os atributos
            //Console.WriteLine(amigo.UsaPhotoshop); não possui acesso para os atributos
        }
    }

    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido() .MeusAcessos();

            new AmigoDistante().MeusAcessos();

        }
    }
}
