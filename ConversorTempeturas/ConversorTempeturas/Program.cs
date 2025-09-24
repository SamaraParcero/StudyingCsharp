using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTempeturas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os valores em celsius");
            double celsius, farenheit, kelvin;
            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            farenheit = ((celsius * 9) / 5) + 32;
            kelvin = celsius + 273.15;
            Console.WriteLine("Faremheit: "+ farenheit);
            Console.WriteLine("Kelvin: " + kelvin);
        }
    }
}
