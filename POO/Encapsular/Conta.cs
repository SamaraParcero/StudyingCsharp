using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        private string cliente;
        private double saldo;

        public string Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                if (value != "Samara" && value != "pedro")
                {
                    cliente = "Visitante";
                    Saldo = 0;   
                }
                else
                {
                    cliente = value;
                    Saldo = 100;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                saldo = value;
            }
        }


        private double taxa = 10;


        public void Sacar(double valor)
        {
            valor += taxa;
            saldo -= valor;
        }

        public void Depositar(double valor) 
        {
            saldo += valor;
        }


    }
}
