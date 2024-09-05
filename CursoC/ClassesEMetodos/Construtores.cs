using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //Construtor passando parâmetros
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        //Construtor padrão
        public Carro()
        {

        }
    }
    internal class Construtores
    {        
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "Volkswagem";
            carro1.Modelo = "Golf GTI";
            carro1.Ano = 2023;
            Console.WriteLine($"{carro1.Fabricante}, {carro1.Modelo}, {carro1.Ano}");

            var carro2 = new Carro("Ford", "Focus", 2018);
            Console.WriteLine($"{carro2.Fabricante}, {carro2.Modelo}, {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Citroen",
                Modelo = "C3",
                Ano = 2014
            };
            Console.WriteLine($"{carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
