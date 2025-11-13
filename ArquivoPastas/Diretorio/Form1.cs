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
using static System.Net.WebRequestMethods;

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string path = @"g:\ProjetosGithub\CursoCSharp\";
            bool res = Directory.Exists(path + "Samara");
            lista.Items.Add(res);
            
            //Criar diretorio
             if (!res)
             {
                 Directory.CreateDirectory(path + "Samara");
             }

             //Deletar
             if (res)
             {
                 Directory.Delete(path + "Samara");
             }

            if (res)
            {
                //move arquivo
                Directory.Move(path + "Samara", path + @"destino\SamaraCopia");
            }
            

            //Pego todos os diretorios existentes nesse path
            string[] dirs = Directory.GetDirectories(path);

            foreach(string d in dirs)
            {
                lista.Items.Add(d);
            }
            

            //Pego todos os arquivos dessa pasta
            string[] files = Directory.GetFiles(path);

            foreach (string f in files)
            {
                lista.Items.Add(f);
            }
            
            //Mostra diretórios raiz
            string root = Directory.GetDirectoryRoot(path);
            lista.Items.Add(root);
            
            
            //Pega os drives
            string[] drives = Directory.GetLogicalDrives();
            lista.Items.Add(drives);

            //pegar informações dessa pasta
            DirectoryInfo info = Directory.GetParent(path);
            lista.Items.Add(info.FullName);

            //Ver o diretório atual -> Executável
            string dir = Directory.GetCurrentDirectory();
            lista.Items.Add(dir);

        }
    }
}
