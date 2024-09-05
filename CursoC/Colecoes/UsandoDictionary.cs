using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Colecoes
{
    internal class UsandoDictionary 
    {
        public static void Executar()
        {
            //o int é a chave e string o valor
            //a chave não aceita repetição, mas o valor aceita
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2004, "Os incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                //busca o filme pela chave, caso não encontre mostra erro na tela
                Console.WriteLine("2004: " + filmes[2004]);
                //O método GetValueOrDefault pega o valor selecionado, e caso não encontre traz um valor vazio sem mostrar erro
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
            //faz a busca pelo valor
            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            //remove um filme da lista pela chave
            Console.WriteLine($"Removeu: {filmes.Remove(2004)}");

            //Busca o filme pela chave tb, mas utilizando o metodo out
            //se não encontrar não gera erro
            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}");

            //percorre o dicionario trazendo as informações das chaves 
            foreach (var chave in filmes.Keys) 
            {
                Console.WriteLine(chave);
            }

            //percorre o dicionario trazendo as informações dos valores
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            //percorre o dicionario trazendo as informações das chaves e valores
            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é do ano de {filme.Key}");
            }
        }
    }
}
