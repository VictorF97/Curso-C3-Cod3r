using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos
{
    //Métodos estáticos "STATIC" podem ser acessados ser serem instanciados "new Calculadora
    internal class CalculadoraEstatica
    {
        //Método de Classe ou Método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    internal class MetodoEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(3, 6);
            Console.WriteLine(resultado);

            //instanciando o método Somar da classe, que não é estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(9,8));
        }
    }
}
