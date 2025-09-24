using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Apresentando ifs
            int valor = 25;

            if (valor > 4)
            {
                Console.WriteLine("Condição verdadeira");
            } else
            {
                Console.WriteLine("Condição Falsa");
            }
            #endregion

            #region verificação encadeada
            if (valor < 5)
            {
                Console.WriteLine("Menor que 5");
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Maior igual que 5 e menor que 10");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Maior igual a 10 e menor que 20");
            } else
            {
                Console.WriteLine("Condição não atendida");
            }

            #endregion

            #region condicionais aaninhadas
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("O número é maior que 5");
                if (num % 2 == 0)
                {
                    Console.WriteLine("Par!");
                }
                else
                {
                    Console.WriteLine("Impar!");
                }
            }
            #endregion

            #region Operador ternário
            int numero = 10;
            string mensagem = "";

            //condição? true : false;
            //mensagem = numero > 5? "Maior que 5" : "Menor que 5";

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");
            
                #endregion

            Console.ReadKey();
        }
    }
}
