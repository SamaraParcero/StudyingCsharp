using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declarando instâncias das classes
            MinhaClasse classe = new MinhaClasse();
            OutraClasse outraClasse = new OutraClasse();
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Samara";
            p1.sobrenome = "Parcero";
            p1.anoNascimento = 1985;

            p1.Cumprimentar();


            Pessoa p2 = new Pessoa()
            {
                nome = "Wilson",
                sobrenome = "Parcero",
                anoNascimento = 1975
            };
            p2.Cumprimentar();
        }
    }

    class MinhaClasse
    {

    }
}
