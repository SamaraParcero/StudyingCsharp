using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Executa essa Main e Tarefa ao mesmo tempo pois são Threads separadas
            Thread t = new Thread(new ThreadStart(Tarefa));
            //Finaliza a thread secundária quando a primária acabar
            t.IsBackground = true;
            t.Start();
            //Pausa a thread principal para que finalize a secundária
            t.Join();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                //A cada for, descansa meio segundo
                Thread.Sleep(500);
            }

            //Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa executada");
                Thread.Sleep(1000);
            }
        }
    }
}
