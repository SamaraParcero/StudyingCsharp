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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = @"G:\ProjetosGithub\CursoCSharp\";
            string arquivo = "teste.txt";

            //Verifica se existe
            bool res = File.Exists(Path.Combine(pasta, arquivo));
            label1.Text = res.ToString();

            //Deleta o arquivo
            //File.Delete(pasta + arquivo);

            //Cria arquivo
            if(!File.Exists(pasta+ arquivo))
            {
                File.Create(pasta + arquivo).Close();
                label1.Text = "Criado";
            }
            else
            {
                label1.Text = "Já existe";

            }

            //Copiar arquivo
            if(File.Exists(pasta + arquivo))
            {
                File.Copy(pasta + arquivo, pasta + "copia.txt", true); // -> Esse true permite sobresescrita
                label1.Text = "Copiado";
            }
            else
            {
                label1.Text = "Arquivo não existe";

            }

            //Copia porém Se tiver mesmo nome, ele muda pro nome indicado
            //File.Move(pasta + arquivo, pasta + "destino\\"+ arquivo);

            //Escreve no arquivo
            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.Default);

            //Leitura de arquivos
            //label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);

            //Obtenho retorno da data de criação
            label1.Text = File.GetCreationTime(pasta + arquivo).ToString();


        }
    }
}
