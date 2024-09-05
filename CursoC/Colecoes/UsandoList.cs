﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;

            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    internal class UsandoList 
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinhoCompra = new List<Produto>();
            carrinhoCompra.Add(livro);

            var combo = new List<Produto> { 
                new Produto("Camisa", 29.9),
                new Produto("8° temporada Game oh Thrones", 50.0),
                new Produto("Poster", 15.5)            
            };

            carrinhoCompra.AddRange(combo); //adiciona vários elementos de uma vez
            Console.WriteLine(carrinhoCompra.Count);
            carrinhoCompra.RemoveAt(3); //remove um item de lista

            foreach(var carrinho in carrinhoCompra)
            {
                Console.WriteLine(carrinhoCompra.IndexOf(carrinho));
                Console.WriteLine($" {carrinho.Nome} {carrinho.Preco}");
            }
        }
    }
}
