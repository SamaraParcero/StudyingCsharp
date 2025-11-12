using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá, meus amigos");

            //Text e título dele
            MessageBox.Show("Mensagem", "título da mensagem");

            //Text, título e tipo de botão
            //MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.YesNo);
            DialogResult res = MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {
                lblResultado.Text = "Clicou em OK";
            }
            else if( res == DialogResult.Cancel) {

                lblResultado.Text = "Clicou em Cancelar";
            }

            //Com icone no messagebox
            MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //Se defirnirmos um parâmetro a semente é fixa
            Random r = new Random();
            //Gera entre 0 e 100
            int valor =r.Next(100);

            //Gera entre 100 e 199
            int valor1 = r.Next(100,200);

            lblResultado.Text = "Número: " + valor;

            //Ex com parâmetro para ser aleatório
            Random r2 = new Random(DateTime.Now.Millisecond);
            //Para gerar double
            double valor2 = r2.NextDouble();
            lblResultado.Text = "Número: " + valor2;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //Transforma minutos em hora
            //lblResultado.Text = TimeSpan.FromMinutes(90.5).ToString();

            //Transforma dias em horas
            //lblResultado.Text = TimeSpan.FromDays(90.5).ToString();

            //Transforma tics em horas 
            lblResultado.Text = TimeSpan.FromTicks(100000000).ToString();

            //Transforma tics em um minuto
            lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            //Passa 5h, 30 min e 30 segs
            TimeSpan inicio = new TimeSpan(5, 30, 30);
            TimeSpan fim = new TimeSpan(18, 25, 30);
            TimeSpan intervalo = fim - inicio;

            //Métodos para fazer essas operações
            //Temos o inicio e adicionamos o fim
            TimeSpan intervalo2 = inicio.Add(fim);

            //Temos o fim  e subtraimos o inicio
            TimeSpan intervalo3 = fim.Subtract(inicio);


            lblResultado.Text = intervalo2.ToString();

            //Se eu quiser pegar só horas
            double horas = intervalo.TotalHours;
            lblResultado.Text = horas.ToString();
            
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //Estrtura de data e hora
            lblResultado.Text = DateTime.Now.ToString();
            //O dia de hoje
            lblResultado.Text = DateTime.Today.ToString();
            //Dias no mês
            lblResultado.Text = DateTime.DaysInMonth(2025, 11).ToString();

            //Ano bissexto
            lblResultado.Text = DateTime.IsLeapYear(2025).ToString();

            //Data longa
            lblResultado.Text = DateTime.Now.ToLongDateString();
            //Data abreviada - Sem segundos e afins
            lblResultado.Text = DateTime.Now.ToShortDateString();

            //Valor da data universal
            lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();

            //Formatando como quero
            lblResultado.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            DateTime data = new DateTime(2005, 01, 23, 02, 15, 20);
            lblResultado.Text = data.AddYears(5).ToString();

            //Adicionando TimeSpan
            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            lblResultado.Text = data.Add(tempo).ToString();

            //Dia do ano
            lblResultado.Text = data.DayOfYear.ToString();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            //Define cor das propriedades dos componentes
            lblResultado.BackColor = vermelho;
            lblResultado.ForeColor = Color.LightBlue;

            //Usando o RGB, o primeiro parâmetro é a transparência
            Color cor1 = Color.FromArgb(100, Color.DarkGreen);
            Color cor2 = Color.FromArgb(100, 255, 100, 135);

            //Cores conhecidas 
            Color cor3 = Color.FromKnownColor(KnownColor.Control);
            //Pelo nome conhecido 
            Color cor4 = Color.FromName("DarkRed");

            lblResultado.BackColor = cor4;
            lblResultado.ForeColor = cor3;

            //Pegando a cor de fundo
            Color cor5 = lblResultado.BackColor;

            btnColor.BackColor = cor5;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //Se não acha uma font vai para a próxima
            Font letra= new Font("Helvetica, Arial, sans-serif", 36, FontStyle.Regular | FontStyle.Bold, GraphicsUnit.World);
            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C#, trabalho com fontes";

            lblResultado.Font = letra2;

        }

        private void btnEnviroment_Click(object sender, EventArgs e)
        {/*
            //Pega o endereço da pasta indicada
            string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //Enviroment.CurrentDirectory = "C:\\"
            string dirAtual = Environment.CurrentDirectory;
            //Quebra de linha:
            //Environment.NewLine;
            lblResultado.Text = dirAtual +Environment.NewLine+ meusDocs;

            //Pegar variavel de ambiente
            string varAmb = Environment.GetEnvironmentVariable("Path");
            lblResultado.Text = varAmb;


            //Todos os discos do pc
            string[] discos = Environment.GetLogicalDrives();

            foreach (string item in discos)
            {
                lblResultado.Text += "\n" + item;
            } */

            //Obter user
            string user = Environment.UserName;
            string dominio = Environment.UserDomainName;
            int cpu =Environment.ProcessorCount;

            lblResultado.Text = cpu.ToString();



        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            //Application.Exit()

            //Mostrar o executável da aplicação
            string exec = Application.ExecutablePath;


            string pasta = Application.StartupPath;

            //Reestarta a aplicação
            Application.Restart();

            lblResultado.Text = exec;
        }
    }
}
