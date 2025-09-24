using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Saida
            //Console.WriteLine("Samara");
            //Console.Write("Artigas");
            #endregion

            #region Entrada
            //int codigo = Console.Read();
            string texto = Console.ReadLine();
            Console.WriteLine(texto);
            #endregion

            #region Inverter Strings
            string nome1, nome2, nome3, auxiliar ;
            Console.WriteLine("Digite nome 1:");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite nome 2:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite nome 3:");
            nome3 = Console.ReadLine();

            //Mecanismo de inversão
            auxiliar = nome1;
            nome1 = nome3;
            nome3 = auxiliar;
            auxiliar = nome2;
            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na sequência invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);   


            #endregion

            Console.ReadKey();
        }
    }
}
