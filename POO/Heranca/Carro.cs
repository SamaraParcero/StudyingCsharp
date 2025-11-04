using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }

        public void LigarMotor()
        {
            Console.WriteLine("Carro ligou Motor!");
        }

        
    }
}
