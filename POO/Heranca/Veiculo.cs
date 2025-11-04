using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    //Classe usada apenas como base para outras classes -> Não é possível instanciar
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        //Cada Classe que herda deve fazer sua própria implementação
        public abstract void Acelerar();

        public abstract void Parar();
    }
}
