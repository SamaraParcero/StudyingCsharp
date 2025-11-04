using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursiva r = new Recursiva();
            r.ExecutarRecursivo("Olá, mundo!", 5);
            Console.ReadKey();
        }
    }
}
