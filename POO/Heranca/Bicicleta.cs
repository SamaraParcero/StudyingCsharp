using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    // Classes sealed não podem ser herdadas
    sealed class Bicicleta : Veiculo
    {
        //Método abstrato que está sendo sobrescrito
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a Bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }

        public void Pedalar()
        {
            Console.WriteLine("Começar a pedalar");
        }
   

        
    }
}
