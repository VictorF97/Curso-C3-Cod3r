using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.OrientacaoAObjetos
{
    //Uma classe abstrata não pode ser instanciada
    public abstract class Celular
    {
        //um método abstrato diz que alguma classe herdar da class Celular, ela obrigatoriamente deverá ter esse método Assistente(), se a classe for concreta
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim Trim Trim...";
        }
    }

    public class Samsumg : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Siri";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            //Uma classe abstrata não pode ser instanciada
            //Celular celular = new Celular();

            var celulares = new List<Celular>()
            {
                new Iphone(),
                new Samsumg()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
