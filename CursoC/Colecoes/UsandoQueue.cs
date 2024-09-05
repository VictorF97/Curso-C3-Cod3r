using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoC.Colecoes
{
    internal class UsandoQueue
    {
        public static void Executar()
        {
            //Queue - Fila first in, first out - FIFO
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");

            //pega o primeiro elemento da fila, mas não o remove
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //remove a primeira pessoa da lista
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Alface");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("alface"));
            Console.WriteLine(salada.Contains("Alface"));


        }
    }
}
