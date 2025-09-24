using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo while
            int valor =0;
            while (valor< 10)
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            }
            #endregion

            #region Ciclo do-while
            //Roda pelo menos 1 vez
            int valor2 = 15;
            do
            {
                Console.WriteLine("O valor é " + valor2);
                valor2++;
            } while (valor2 <5 );
            #endregion

            #region Ciclo For
            for (int i = 0, j =10; i < 10; i++, j--)
            {
                Console.WriteLine("I = " + i + " | J = " + j);
            }
            #endregion

            #region Ciclo Foreach
            string[] nomes = { "Samara", "Gabie", "Stella", "Uelisson", "Murilo" };

            foreach(string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            #endregion
        }
    }
}
