using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        enum Notas
        {
            Minimo = 10,
            Medio = 20,
            Maximo =30
        }

        struct Pessoa // Define uma estrutura de dados
        {
            public string nome;
            public int idade;
            public double altura;
        }

      
        static void Main(string[] args)
        {
            #region Numericas Integrais
            ////Integral assinado
            //sbyte num1 = 10; //8 bits, -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483.648  a 2.147.483.647
            //long num4 = 40L; //64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            ////Integral sem sinal
            //byte num5 = 10; //8 bits, 0 a 255
            //ushort num6 = 20; //16 bits, 0 a 65.535
            //uint num7 = 30; //32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; //64 bits, de 0 a 18.446.744.073.709.615

            //sbyte numero = 120;
            //numero = num1;
            #endregion

            #region Numericas reais

            float real1 = 100.75f; //32 bits, de 1,5 x 10-45 a 3,4 x 1038
            double real2 = 1000.754; // 64 bits, de 5,0 x 10-324  a 1,7 x 10308
            decimal real3 = 752538.457m; // 128 bits, intervalo -7,9 x 10 -28 a 7,9 x 1028

            double valor;
            valor = real1;
            #endregion

            #region Charactere
            char letra = '\u0061';
            char escape = '\n';
            #endregion

            #region Booleano
            bool verificar = false;
            verificar = true;
            #endregion

            #region String

            string texto = @"texto 1986 \n sim";
            string mensagem = null;
            mensagem = texto;

            #endregion

            #region VAR
            var valores = 140; //Aceita qualquer tipo de valor, desde que não mude depois.
            valores = 200;



            #endregion

            #region Object
            object obj = "Gabriel"; // Base de variável para qualquer tipo de dado, assume qualquer valor
            obj = 200;
            #endregion

            #region Constantes
            const double pi = 3.1415;// Constantes permanecem sempre iguais


            #endregion


            #region ENUM

            Notas notasAlunos = Notas.Medio;

            #endregion

            #region Struct
            Pessoa p1 = new Pessoa();
            p1.nome = "Samara";
            p1.idade = 20;
            p1.altura = 1.65;

            Pessoa p2 = new Pessoa()
            {
                nome = "SIm",
                idade =20,
                altura = 1.70
            };
            #endregion



            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
