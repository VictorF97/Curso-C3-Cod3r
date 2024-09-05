using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.Colecoes
{
    //FIRST IN FIRST OUT - FIFO
    internal class UsandoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }
            //Comando POP remove o ultimo item adicionado da lista
            Console.WriteLine($"\n Pop: {pilha.Pop()} \n");

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }
            //Comando PEEK seleciona o ultimo item da lista, mas não remove
            Console.WriteLine($"\n Pick: {pilha.Peek()}");
        }
    }
}
