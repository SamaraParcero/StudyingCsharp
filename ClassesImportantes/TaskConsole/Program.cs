using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task Parte 1
            /*
            //Formas de rodar tarefas
           // Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);

            
            //Outra forma de iniciar tarefa
            Task.Factory.StartNew(Tarefa);
            Task.Run(() => 
            {

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa anônima");
            }


            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa principal");
            }*/
            #endregion
            #region Parte 2
            /*
            //Array de tasks 
            Task[] tasks =
            {
                Task.Factory.StartNew(()=>
                {
                    Console.WriteLine("Tarefa #1");
                }),

                Task.Factory.StartNew(()=>
                {
                    Console.WriteLine("Tarefa #2");

                }),

                Task.Factory.StartNew(()=>
                {
                    Console.WriteLine("Tarefa #3");

                })
            };

            Task t1 = Task.Run(() => { Console.WriteLine("Comando 1"); });
            Task t2 = Task.Run(() => { Console.WriteLine("Comando 2"); });
            Task t3 = Task.Run(() => { Console.WriteLine("Comando 3"); });
            Task.WaitAll(t1, t2, t3);

            //Como executar só depois das terfas:
            Task.WaitAll(tasks);
            //Assim o principal fica sempre no final
            Console.WriteLine("Principal.");*/
            #endregion

            #region Ordenando Tasks
            //Como obter retorno de uma tarefa
            //Task<int> tarefa1 = Task.Factory.StartNew(() =>Dobro(5));
            //Console.WriteLine(tarefa1.Result);

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);
            });

            //Cria continuação da tarefa anterior
            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return "Valor final: " + num.Result;
            });

            Console.WriteLine(tarefa3.Result);
            #endregion
            Console.ReadKey();
        }
        static int Dobro(int num)
        {
            return num * 2;
        }

        private static void Tarefa()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do task");
            }
        }
    }
}
