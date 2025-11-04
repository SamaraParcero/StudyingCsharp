using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        //Método semelhante aos de abstract, porém pode ter implementação base
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }

    }

    class Pessoa : Humano
    {
        //A partir desse momento esse método não pode ser mais modificado
        public sealed  override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }

    }

    class Homem: Pessoa 
    {

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }


    }
}
