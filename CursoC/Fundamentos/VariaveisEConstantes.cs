using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área É: " + area);

            //Tipos internos 
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo agora? " +  estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: " + saldoGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário : " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor inteiro: " + menorValorInt);

            uint populacao = 207_600_000;
            Console.WriteLine("População brasileira: " + populacao);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor valor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float preco = 1299.99f;
            Console.WriteLine("O preço é: " + preco);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso C#";
            Console.WriteLine(texto);


        }
    }
}
