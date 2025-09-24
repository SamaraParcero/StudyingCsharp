using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            byte num1 = 100; //8 bits
            ushort num2; //16 bits

            num2 = num1; //Permite, pois 8 cabe em 16

            float num3 = 1250.45f;
            double num4 = num3;

            num3 = num1;//Float suporta byte

            int numero = 'c'; // Recebe código numérico


            #endregion

            #region Conversão Explicita
            ushort num1e = 100;
            byte num2e = (byte)num1; //CAST: CONVERSÃO EXPLICITA DE DADOS

            float num3e = 2500.66f;
            int num4e = (int)1985.75f;

            char letra = (char)97;


            Console.WriteLine(num4e);

            #endregion

            #region Conversão Parse
            string txtNumero = "1985";

            int numeroParse = int.Parse(txtNumero); //Metodo de conversão

            byte numParse = byte.Parse("120");

            double numParse2 = double.Parse("123245,57");//Colocar vírgula em string

            float numParse3 = float.Parse("457,75");

            Console.WriteLine(numParse3);
            #endregion

            #region Classe Convert
            string conversao = Convert.ToString(250); //Método de conversão para qualquer valor, nesse caso string

            double numParse4 = Convert.ToDouble(false);
            Console.WriteLine(numParse4);

            int numParse5 = Convert.ToInt32('a');
            Console.WriteLine(numParse5);


            #endregion
        }
    }
}
