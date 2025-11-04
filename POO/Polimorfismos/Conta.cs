using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismos
{
    internal class CaixaEletronico : IConta
    {
        public string Usuario { get ; set ; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        public void Saldo()
        {
            
        }

        public void SolicitarEmprestimo()
        {

        }
    }

    //Começamos interface com I na frente
    interface IConta
    {
        //Métodos por padrão já são abstratos, portanto são obrigados a serem implementados
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
