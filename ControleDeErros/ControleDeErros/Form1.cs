using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 10, 20, 30, 40, 50 };

            try
            {
                string res = "";
                for (int i = 0; i < num.Length ; i++)
                {
                    res += num[i] + " ";
                }

                label1.Text = res;
            } catch (Exception ex) // Só é executado com erro
            {
                //Pego apenas a mensagem de erro no e.Message
                label1.Text = "Erro! \n" + ex.Message;
            }//Finally sempre é executado se der erro ou não
            finally 
            {
                MessageBox.Show("Operação finalizada");
            }
        }
    }
}
