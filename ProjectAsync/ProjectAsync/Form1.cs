using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsync
{
    public partial class Form1 : Form
    {
        public static ListBox listResult;
        public Form1()
        {
            InitializeComponent();
            listResult = listaResultado;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Add("Evento do botão foi iniciado: Cliquei aqui");

            Exemplo obj = new Exemplo();
            obj.Task_LongaDuracao();
            listaResultado.Items.Add("Evento do botão foi concluído");
        }



       private async void btnExecAsync_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Add("Evento do botão foi iniciado : cliquei aqui");

           ExemploAsync obj = new ExemploAsync();
           await obj.Task_LongaDuracao();
           listaResultado.Items.Add("Evento do botão foi concluído");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear(); 
        }
    }
}
