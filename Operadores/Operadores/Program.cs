using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Aritmeticos
            int num = 10;
            int num2 = 2;

         

            Console.WriteLine(num + num2);
            Console.WriteLine(num - num2);
            Console.WriteLine(num * num2);
            Console.WriteLine(num / num2);
            Console.WriteLine(num % num2);
            #endregion

            #region Prioridade de sinais
            int num1 = 100;
            int num21 = 10;
            int num3 = 5;

            int res = (num1 + num2) * num3;//soma prioridade
            int res2 = num1 + num2 * num3;//multiplicação como prioridade


            Console.WriteLine(res);

            #endregion

            #region Incremento e decremento

            int numid = 10;
            //numid = numid + 1; //Isso se resume no de baixo
            //numid++;
            Console.WriteLine(numid);
            //numid--;
            Console.WriteLine(numid);

            Console.WriteLine(++numid);//Processa primeiro a variavel e depois acrescenta
            #endregion

            #region Operador de Concatenação

            string nome = "samara" + " parcero" + 2005; //concatenação simples
            Console.WriteLine(nome);

            #endregion

            #region Operador de atribuição

            int numop = 10;

            numop += 10; //20

           
            Console.WriteLine(numop);
            numop -= 8; //12
            Console.WriteLine(numop);

            numop /= 2; //6
            Console.WriteLine(numop);
            numop *= 2; //12
            Console.WriteLine(numop);

            numop %= 2; //0
            Console.WriteLine(numop);

            string nome1 = "samara";
            nome1 += "parcero";

            Console.WriteLine(nome1);
            #endregion


            #region Operadores de igualdade

            bool res1 = 100 == 50;// 100 igual a 50? Falso!
            Console.WriteLine(res1);

             res1 = 100 == (50*2);// 100 igual a 50 vezes 2? Verdadeiro!
            Console.WriteLine(res1);

            bool res22 = 100 != 50;//100 é diferente de 50? True!
            Console.WriteLine(res22);

            string noome = "samara";
            bool res3 = nome == "samara";
            Console.WriteLine(res3);

            #endregion

            #region Operadores relacionais

            bool res4 = 100 < 50*2;
            Console.WriteLine(res4);

            bool res5 = 100 +25 > 50 * 2;
            Console.WriteLine(res5);

            bool res6 = 100 <= 50 * 2;
            Console.WriteLine(res6);


            bool res7 = 100 >= 50 * 2;
            Console.WriteLine(res7);
            #endregion

            #region Operadores lógicos
            bool res8 = 100 > 50;
            bool res9 = 50 == 50;

            bool final = res8 && res9;
            Console.WriteLine(final);

           

            bool final2 = res8 || res9;
            Console.WriteLine(final2);
            #endregion


            Console.ReadKey();

        }
    }
}
