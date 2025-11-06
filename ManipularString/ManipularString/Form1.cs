using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region Contains/ ToString
            /* string texto = "Esse tipo de Variável é alfa numérica";


             //Método que vê se possui uma substring dentro de uma string
             if (texto.Contains("Tipo"))
             {
                 label1.Text = "Contém";
             }
             else
             {
                 label1.Text = "Não contém";
             }*/



            /*int num = 5400;
            bool res = true;
            //Método que transforma qualquer tipo de dado em String
            label1.Text = res.ToString(); */
            #endregion


            #region ToUpper/ToLower
            /*string nome = "samara";
            //Método para tudo Maiusculo
            //label1.Text = nome.ToUpper();

            //Método para tudo em min´´usculo
            label1.Text = nome.ToLower();
            */
            #endregion

            #region IndexOf/LastIndexOf
            /*
             string nome = "Samara";

            //Retorna primeira posição de A
            int num = nome.IndexOf('a');
            int num = nome.IndexOf("ara");

            //A partir de que index procurar
            int num = nome.IndexOf('a', 3);

            //A partir de que index depois do procurado quer parar
            int num = nome.IndexOf('a', 4, 1);


            //Mostra a última ocorrência
            int num = nome.LastIndexOf('a');

            label1.Text = "Indice: " + num;
            */
            #endregion

            #region Insert/Replace
            /*string nome = "Samara";

            //Coloco a partir de um indice uma nova string
            string nomeFinal = nome.Insert(0, "Sam ");

            //Substitui todas as letras As por Es
            string nomeFinal = nome.Replace('a', 'e');
            string nomeFinal = nome.Replace("ar", "ant");

            label1.Text = nomeFinal;*/
            #endregion

            #region Length/ Substring
            /*string nome = "Samara Parcero";

            //Conta a quantidade caracteres que uma string possui
           int tam =nome.Length;

            label1.Text = "O nome " + nome + " contém " + tam + " letras";

            for (int i = 0; i< nome.Length; i++)
            {
                label1.Text+= nome[i] +"\n";
            }

            //Mostra uma substring de um indice  e a quantidade de caracteres
            string parte = nome.Substring(nome.IndexOf(" "), 8);
            label1.Text = parte;
            */
            #endregion

            #region Split
            /*string nomes = "Samara Oliveira_Parcero,Lima";

            char[] separador = { ' ' , ',', '_'};

            //Separa um string de acordo com os separadores declarados
            string[] resultados = nomes.Split(separador);
            label1.Text = "";
            foreach (string nome in resultados)
            {
                label1.Text += nome + "\n";
            }*/
            #endregion

            #region StartsWith/EndsWith
            /*
            string nome = "Samara";
            //Vê se começa com essa string ou não e ignora case sensitive(maiusculas e minusculas)
            bool res = nome.StartsWith("s", StringComparison.OrdinalIgnoreCase);
            //Vê se finaliza com a string
            bool res = nome.EndsWith("a", StringComparison.OrdinalIgnoreCase);
            if (res)
            {
                label1.Text = "Positivo";
            }
            else
            {
                label1.Text = "Negativo";
            }
            */
            #endregion

            #region Trim/TrimStart/TrimEnd
            /*string mensagem = "-Olá, Samara -";

            //Remover espaços do começo ou final
            string mens = mensagem.Trim();
            char[] c = { ' ', '_', '-' };
            //Remove todos os caracteres passados no parâmetro do inicio e final
            string mens = mensagem.Trim(c);


            //Remove só do começo
            string mens = mensagem.TrimStart(c);


            //Remove só do final
            string mens = mensagem.TrimEnd(c);
            label1.Text = ">"+mens+"<";*/
            #endregion

            #region CompareTo/Equals
            /*string nome = "Samara";
            string nome2 = "Tamara";

            //Retorna true se for igual
            if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            {
                label1.Text = "Positivo";
            }
            else
            {
                label1.Text = "Negativo";
            }

            //Comparar em ordem alfabética, se uma string foi antes do outro. Se foi antes 1 e se for depois -1
            label1.Text = nome.CompareTo(nome2).ToString();
            */
            #endregion

            #region Format
            /*
            decimal valor = 19.95m;
            int temp = 32;

            //Substitui o valor das chaves pela variável
            // O {0:N3} indica a quantidade de decimais e {0:C3} indica reais
            string s = String.Format("O valor do produto é {0:C3} e a temperatura é {1}", valor, temp);
            string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);

             string s = $"{valor} é o valor do produto";
            string s = $"Hoje é {DateTime.Now:D} e são {DateTime.Now:T}";

            label1.Text = s;
            */
            #endregion
        }
    }
}
