using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressoesLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Expressão Lambda que tem uma expressão como corpo:
            //(input - parameters) => expression

            //Instrução lambda que tem um bloco de instrução como corpo:
            //(input - parameters) => { < sequence - of - statements >}


            //Sem Lambda
            Func<int, int> square1 = quadrado;

            labelResultado.Text = "O resultado é" + square1(1);

            //Com Lambda
            Func<int, int> square = x => x*x;

            labelResultado.Text = "O resultado é" + square(1);

            //Mostrar Expressão
            Expression<Func<int, int>> ex = x => x + x;

            labelResultado.Text = ex.ToString();

            //LINQ
            int[] numbers = { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x=> x*x);
            labelResultado.Text = string.Join(", ", squaredNumbers);

            //Instrução
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                labelResultado.Text = greeting;
            };

            greet("Samara");

            Action line = () => Console.WriteLine();

            Console.WriteLine("Samara" );
            line();
            Console.WriteLine("Parcero");

            //Mais que um parâmetro de entrada
            Func<int, int, bool> testForEquality = (x,y) => x == y;
            labelResultado.Text = testForEquality(10,10).ToString();
        }

        int quadrado(int x)
        {
            return x * x;
        }
    }
}
