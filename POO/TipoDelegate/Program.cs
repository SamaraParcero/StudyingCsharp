using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        //Chama todos da classe matemática
        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {

            Matematica matematica = new Matematica();

            Operacao conta = null;
            conta += matematica.Somar;
            conta += matematica.Subtrair;
            conta += matematica.Multiplicar;
            conta += matematica.Multiplicar;
            conta += matematica.Dividir;
            conta(10, 2);

            Console.WriteLine();

            conta -= matematica.Dividir;

            conta(2, 3);
            Console.ReadKey();
        }
    }
}
