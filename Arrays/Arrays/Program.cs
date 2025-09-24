using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYS
            int numero = 0;

            int[] numeros = new int[5];
            numeros[0] = 10;

            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            Console.WriteLine(numeros[2]);

            string[] nomes = new string[5];
            nomes[0] = "oliveira";

            nomes[1] = "samara";
            nomes[2] = "lima";
            nomes[3] = "parcero";
            nomes[4] = "benaia";

            Console.WriteLine(nomes[2]);

            string[] aleatorio = { "samara", "SOPHIA", "GABRIEL" };//VETOR DE 3 ELEMENTOS

            #endregion

            #region MATRIZ

            int[,] numeros1 = new int[2, 3];//2 linhas, 3 colunas

            numeros1[0, 0] = 10;
            numeros1[0,1] = 20;
            numeros1[0,2] = 30;

            numeros1[1, 0] = 40;
            numeros1[1, 1] = 50;
            numeros1[1, 2] = 60;
            Console.Write("[" + numeros1[0, 0] + "]");
            Console.Write("[" + numeros1[0,1]+ "]");
            Console.Write("[" + numeros1[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros1[1, 0] + "]");
            Console.Write("[" + numeros1[1, 1] + "]");
            Console.Write("[" + numeros1[1, 2] + "]");

            string[,] nomess =
            {   //coluna
                {"samara", "parcero", "lima" },//linha
                {"linha", "amigos", "sono" }

            };
            Console.Write("[" + nomess[1, 1] + "]");

            #endregion
        }
    }
}
