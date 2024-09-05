using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Colecoes
{
    internal class UsandoSet 
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            //set é uma estrutura que não é indexada e não aceita repetição
            var carrinhoCompra = new HashSet<Produto>();
            carrinhoCompra.Add(livro);

            var combo = new HashSet<Produto> { 
                new Produto("Camisa", 29.9),
                new Produto("8° temporada Game oh Thrones", 50.0),
                new Produto("Poster", 15.5),
                new Produto("Poster", 15.5),

                //incluindo o livro, mas n será adicioanda pois é duplicado
                livro
            };

            carrinhoCompra.UnionWith(combo); //adiciona todos os itens que não possuem duplicidade
            Console.WriteLine(carrinhoCompra.Count);
            //carrinhoCompra.RemoveAt(3); //remove um item de lista

            foreach(var carrinho in carrinhoCompra)
            {
                //Console.WriteLine(carrinhoCompra.IndexOf(carrinho));
                Console.WriteLine($" {carrinho.Nome} {carrinho.Preco}");
            }

            Console.WriteLine(carrinhoCompra.Count);
            carrinhoCompra.Add(livro);
            Console.WriteLine(carrinhoCompra.Count);
           // Console.WriteLine(carrinhoCompra.LastIndexOf(livro));
        }
    }
}
