using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.OrientacaoAObjetos
{
    sealed class SemFilho
    {
        public double ValorFortuna()
        {
            return 1_407_033.65;
        }
    }

    //Não é possível herdar de uma classe sealed
    //classe sealed não permite a sobrescrita "override"
    //public class SouFilho : SemFilho
    //{

    //}

    public class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //não é possível reescrever um método sealed
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
