using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Idade = 19;
            t.Nome = "Samara";
            Console.WriteLine(t.Nome);
            Console.WriteLine(t.Idade);
        }
    }
}
