namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar acessar = new Acessar();

            if (acessar.Login("1111"))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
