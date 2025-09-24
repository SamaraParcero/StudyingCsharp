using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Switch case
            int escolha = 2;
            switch (escolha)
            {
                default:
                    Console.WriteLine("opção padrão");
                    break;
                case 1:
                    Console.WriteLine("Opção 1");
                     break;
                case 2: // se não tiver break, continua para os outros cases
                case 3:
                    Console.WriteLine("opção combinada");
                    break;


            }
        #endregion

        #region go-to
        Inicio:
            Console.WriteLine("Escolha uma opção");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio; // volta para o lugar que vc declarou a label
                    break;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }
            Console.WriteLine("Valor Final " + valor);

            #endregion

            Console.ReadKey();
        }
    }
}
