using CursoCSharp.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ExplorandoApi
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.60;89");
                    sw.WriteLine("Borracha Branca;1.50;26");
                    sw.WriteLine("Caderno de Caligrafia;10.99;47");
                    sw.WriteLine("Estojo Grande;8.00;80");
                }
            }

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
