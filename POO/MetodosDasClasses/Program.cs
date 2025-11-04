namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            #region Métodos Simples
            metodos.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            metodos.Somar(2, 3);

            metodos.Apresentar("Samara", 20);

            int valor1 = 100;
            int valor2 = 100;

            metodos.AumentaValor(valor1);
            metodos.AumentaValorRef(ref valor2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2); // Essa é afetada e fica 110
            #endregion

            #region Métodos com retorno de valores
            Console.WriteLine(metodos.MontaNome("Samara", "Parcero"));

            Console.WriteLine(metodos.CodigoChar('a'));

            Console.WriteLine(metodos.ValorPI());
            #endregion

            #region

            metodos.Cumprimentar();
            metodos.Cumprimentar("Samara");
            metodos.Cumprimentar("Gabriel", 18);

            bool res1 = metodos.Comparar(100, 50 * 2);
            bool res2 = metodos.Comparar("Gabriel", "gabriel");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            #endregion
            Console.ReadKey();



        }
    }
}
