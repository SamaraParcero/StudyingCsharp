using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //Definição de um campo
        private string nome;
        private string sobrenome { get; } = "Artigas";
        private int idade;

        //Definição de uma propriedade
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior que 18 anos");
                }
                else
                {
                    idade = value;
                }
            }
        }



        public void Apresentar()
        {
            if (nome != "")
            {
                Console.WriteLine("Olá, eu sou " + nome);
            }
        }

    
    }
}
