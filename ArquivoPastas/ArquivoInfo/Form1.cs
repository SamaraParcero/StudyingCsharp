using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FileInfo info = new FileInfo(@"G:\ProjetosGithub\CursoCSharp\teste.txt");

            //NOME COMPLETO DO ARQUIVO
            listBox1.Items.Add(info.FullName);
            //NOME DO ARQUIVO
            listBox1.Items.Add(info.Name);
            //EXTENSÃO DO ARQUIVO
            listBox1.Items.Add(info.Extension);
            listBox1.Items.Add(info.Directory.FullName);
            //Pega O NOME DO DIRETORIO
            listBox1.Items.Add(info.DirectoryName);
            //Quando foi criado
            listBox1.Items.Add(info.CreationTime);
            //Se existe
            listBox1.Items.Add(info.Exists);
            //Ultima vez que foi acessado
            listBox1.Items.Add(info.LastAccessTime);
          




        }
    }
}
