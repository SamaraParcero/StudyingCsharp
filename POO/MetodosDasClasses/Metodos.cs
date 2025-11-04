using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo");
        }

        //Métodos com parâmetros
        public void Somar(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("A soma é: " + c);
        }

        public void Apresentar( string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome +" e tenho "+ idade);
        }

        //Passsagem de parâmetros por valor
        public void AumentaValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é "+ valor);
        }

        //Passagem de parâmetros por referência -> Afeta a variável mesmo
        public void AumentaValorRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é " + valor);
        }

        //Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
           // int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        //Sobrecarga de métodos
        public void Cumprimentar(string nome) //O parâmetro que define
        {
            Console.WriteLine("Olá " + nome);
        }

        public void Cumprimentar(string nome, int hora) //O parâmetro que define
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa Tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1,string txt2)
        {
            return txt1 == txt2;
        }




    }
}
