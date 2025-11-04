using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            b.Acelerar();
            c.Acelerar();

            
            #endregion

            Humano a = new Humano();
            Pessoa pe = new Pessoa(); 
            Homem h = new Homem();

            Console.WriteLine("\nHumanos");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            pe.Olhos();
            pe.Cabelos();

            Console.WriteLine("\nHomem");
            h.Olhos();
            h.Cabelos();

            Console.ReadKey();
        }
    }
}
