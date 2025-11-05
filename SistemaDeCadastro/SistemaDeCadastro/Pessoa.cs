using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil {  get; set; }
        public string telefone { get; set; }
        public bool CasaPropria {  get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }


    }
}
