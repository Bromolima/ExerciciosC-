using System.Globalization;

namespace Banco 
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cadastro();
            Console.WriteLine("Dados da sua conta: " + c);
            c.Deposito();
            Console.WriteLine("Dados da sua conta: " + c);
            c.Saque();
            Console.WriteLine("Dados da sua conta: " + c);
        }
    }
}