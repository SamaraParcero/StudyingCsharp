using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiretorioInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"G:\ProjetosGithub\CursoCSharp\");
            //Nome completo
            lista.Items.Add(info.FullName);
            //Arquivo pai
            lista.Items.Add(info.Parent);
            //Nome do diretório
            lista.Items.Add(info.Name);
            //Data de criação do diretório
            lista.Items.Add(info.CreationTime);
            //Se o diretorio existe
            lista.Items.Add(info.Exists);
            //Pasta raiz
            lista.Items.Add(info.Root);
            lista.Items.Add("----------------------------");

            //Pegar diretorios dentro desse diretorio
            DirectoryInfo[] dirs = info.GetDirectories();
            foreach(DirectoryInfo dir in dirs)
            {
                lista.Items.Add(dir.FullName);
            }

            lista.Items.Add("----------------------------");
            //Pegar info dos files desse diretorio
            FileInfo[] files= info.GetFiles();
            foreach (FileInfo f in files)
            {
                lista.Items.Add(f.FullName);
            }


        }
    }
}
