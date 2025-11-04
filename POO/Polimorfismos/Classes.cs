using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismos
{
    public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura {  get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {

        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); //Reaproveita código da classe base
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio* Raio);
            Console.WriteLine("Area circulo " + area);
        }
    }

    //Conforme o tipo assume forma diferente
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); //Reaproveita código da classe base
            Console.WriteLine("Desenhando um retangulo");
        }

        public override void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Area Retangulo " + area);
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); //Reaproveita código da classe base
            Console.WriteLine("Desenhando um triangulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura)/2;
            Console.WriteLine("Area triangulo " + area);
        }
    }
}
