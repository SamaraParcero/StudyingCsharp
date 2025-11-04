using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        //Só pode ser acessado nessa classe 
        private string nome;
        public string sobrenome;

        private void Metodo1()
        {

        }

        public void Executar()
        {

        }
    }

    class Humano
    {
        //Só pode ser acessado por quem herda
        protected string nome;
        private string sobrenome;

        //Restrito a essa aplicação
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 18;
        }
    }
}
