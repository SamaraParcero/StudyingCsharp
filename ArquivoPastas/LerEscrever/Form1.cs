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

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            string path = @"G:\teste\file.txt";
            //Classe para escrita de arquivos
            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);//Adicionar conteudo e não sobreescrever esse true

            //string linha =txtConteudo.Text;
            //Escreve
            //writer.WriteLine(linha);

            string txt = txtConteudo.Text;
            writer.Write(txt);

            //Limpa o que foi escrito
            writer.Flush();
            writer.Dispose();
            writer.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            string path = @"G:\teste\file.txt";
            //Classe para leitura de arquivos
            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            //Lê até o final do arquivo
            // string txt = reader.ReadToEnd();


            //Lê apenas uma linha
            string linha = reader.ReadLine();
            // linha += reader.ReadLine();// Cocatena uma com outra

            /*

            while(linha!= null)
            {
                txtConteudo.Text += linha + "\n";
                linha = reader.ReadLine();
            }
            txtConteudo.Text = linha;
            */

            //Enquanto não chegar no fim do arquivo
            while (!reader.EndOfStream)
            {
                txtConteudo.Text += (char)reader.Read() + " ";
                
            }
            //Sempre precisamos fechar ao terminar
            reader.Close();
        }

        private void btnLerBinary_Click(object sender, EventArgs e)
        {
            string path = @"G:\teste\file.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);//Passa um arquivo file stream, lê BYTE A BYTE

            //Normalmente para ler audio e afins
            /* while(reader.BaseStream.Position != reader.BaseStream.Length)
             {
                 byte b = reader.ReadByte();
                 txtConteudo.Text += (char)b + " ";
             }

            //Lê os bytes
            byte[] buffer = reader.ReadBytes((int)reader.BaseStream.Length);

            foreach(byte b in buffer)
            {
                txtConteudo.Text += (char)b;
            }*/

            //Outra forma de ler bytes direto nos arquiuvos

            buffer = File.ReadAllBytes(path);



            reader.Close();
        }

        private void btnEscreverBinary_Click(object sender, EventArgs e)
        {
            //Serve para arquivos como imagem, video e afins
            string path = @"G:\teste\arquivoNovo.txt";
            //Agr escreve no arquivo
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();
            

        }
    }
}
