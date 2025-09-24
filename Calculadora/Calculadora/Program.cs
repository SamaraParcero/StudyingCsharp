using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Write("Digite o primeiro numero");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número");
            double num2 = double.Parse(Console.ReadLine());

        Refaz:
            Console.WriteLine("Escolha sua operação (+ - x /): ");

            char opcao = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcao) {

                default:
                    goto Refaz;
                    break;
                case '+':
                    resultado = num + num2;
                    Console.WriteLine("Resultado da operação: " + resultado);
                    break;
                case '-':
                    resultado = num - num2;
                    Console.WriteLine("Resultado da operação: " + resultado);
                    break;
                case 'x':
                    resultado = num * num2;
                    Console.WriteLine("Resultado da operação: " + resultado);
                    break;
                case '/':
                case ':':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0");
                    }
                    else
                    {
                        resultado = num / num2;
                        Console.WriteLine("Resultado da operação: " + resultado);
                    }
                    break;
            }
            Console.WriteLine("Continua calculando? (s/n)?");
            string opcao2 = Console.ReadLine();
            if(opcao =='s' || opcao == 'S'){
                goto Inicio;
            }

            Console.ReadKey();

        }
    }
}
