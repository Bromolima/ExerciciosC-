using System.Globalization;

namespace Pensionato
{   
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] vet = new Estudante[10];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: "); string nome = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Quarto: "); int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante{ Nome = nome, Email = email };
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i ++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}