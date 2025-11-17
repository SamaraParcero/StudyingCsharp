using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            CriptoStringMD5 md5 = new CriptoStringMD5(); 
            txtSaida.Text = md5.RetornarMD5(txtEntrada.Text);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string senhaBanco = "285315D3547D826393B5884CFA9FE4C3"; //samara
            string senha = txtEntrada.Text;
            CriptoStringMD5 md5 = new CriptoStringMD5();

            if(md5.CompararMD5(senha, senhaBanco))
            {
                labelResultado.Text = "Senhas iguais";
            }
            else
            {
                labelResultado.Text = "Senhas diferentes";
            }
        }
    }
}
