using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Size tamanho = new Size();
            tamanho.Width = 400;
            tamanho.Height = 200;


            InitializeComponent();
            this.Text = "Samara Parcero";
            //Usando size com comprimento e largura
            //this.Size = new Size(400, 200);
            this.ControlBox = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a form";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Evento mouse acionado";
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Evento Mouse enter acionado";
        }
    }
}
