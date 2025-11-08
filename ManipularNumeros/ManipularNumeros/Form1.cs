using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region TryParse
            //Tenta converter valor para o numero inteiro
            /*int num;
            //bool res = int.TryParse("1985aaaaa", out num);

            if (int.TryParse("1985ajjaja", out num))
            {
                lblResultado.Text = num.ToString();
            } else
            {
                lblResultado.Text = "Erro ao converter!";
            }*/
            #endregion

            #region ToString
            /*
            int num = 120;

            //Define quantidade de números que deve apresentar e acrescenta mais zeros se necessário
            //lblResultado.Text = num.ToString("#.00");

            int num = 11;
            //Mostra em hexadecimal
            lblResultado.Text = num.ToString("X"); //Hex
            lblResultado.Text = num.ToString("D"); //DEC
            lblResultado.Text = num.ToString("C"); //Monetario
            //Defino quantidade de digitos que quero
            lblResultado.Text = num.ToString("X3"); 

            lblResultado.Text = Convert.ToString(num, 8);// Converto o número para base hexa ou que eu quiser
            */
            #endregion

            #region Classe Math

            double pi = Math.PI;

            double E = Math.E;
            Math.Sin(1); //Seno de 1
            Math.Cos(1); //Cosseno de 1
            double potencia = Math.Pow(2, 5); //Potência de 2 elevado a 5
            double raizQuadrada = Math.Sqrt(49);
            double arredonda = Math.Round(158.89);
            double inteiro = Math.Truncate(32.57);
            double floor = Math.Floor(52.75); //Arredonda para baixo
            double ceil = Math.Ceiling(52.25); //Arredonda para cima

            lblResultado.Text = ceil.ToString();

            #endregion




        }
    }
}
