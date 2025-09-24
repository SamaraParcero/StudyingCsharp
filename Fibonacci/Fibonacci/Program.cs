using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int soma = 0;

            Console.WriteLine("Quantos valores?");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci com "+ valores + "valores!");
            for (int i = 0; i < valores; i++)
            {
                if(i < valores -1)
                {
                    Console.WriteLine(num1 + ", ");
                }
                else
                {
                    Console.WriteLine(num1);
                }

                soma = num1 + num2;
                num1 = num2;
                num2 = soma;
            }

            Console.ReadKey();


        }
    }
}
