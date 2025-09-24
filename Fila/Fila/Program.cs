using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {


           int[] fileira = new int[5];


            int inicio = 0;
            int fim = 0;
            int tamanho = 0;
            int capacidade = fileira.Length;


            for (int i = 0; i < fileira.Length; i++)
            {

            }


            void Queue(int num)
            {
                if (tamanho == capacidade)
                {
                    Console.WriteLine("A fila estás cheia");
                }
                else { 
                    fileira[fim] = num;
                fim = (fim + 1) % capacidade;
                tamanho++;
                Console.WriteLine("Enfileirado: " + num);
                }
            }



            void Dequeue()
            {
                if (tamanho == 0)
                {
                    Console.WriteLine("A fila está vazia");
                }
                else
                {
                    int dequeued = fileira[inicio];
                    inicio = (inicio + 1) % capacidade;
                    tamanho--;

                    Console.WriteLine("Removido: " + dequeued);

                }     
            }

            void viewQueue()
            {
                if (tamanho == 0)
                {
                    Console.WriteLine("A fila está vazia");
                    return;
                }

                for (int i = 0; i < fileira.Length; i++)
                {
                    Console.WriteLine(fileira[i]);
                }
            }

            Queue(10);
            Queue(20);
            Queue(30);
            Queue(40);
            Queue(50);
            Queue(60);
            viewQueue();
        }


    }
}
