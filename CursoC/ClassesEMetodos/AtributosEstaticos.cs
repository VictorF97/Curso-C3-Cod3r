using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        //atributos estáticos não podem ser acessados como instancias
        public static double Desconto = 0.1;

        //  CONSTRUTOR COM PARAMETROS
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        //CONSTRUTUR SEM PARAMETRO
        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            //deixando o desconto igual para todos os produtos
            Produto.Desconto = 0.5;

            Console.WriteLine("O preço do produto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("O preço do produto: {0}", produto2.CalcularDesconto());
        }
    }
}
