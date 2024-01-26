using Exercicio1;
using System;

namespace exercicio
{
    class program 
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Insira os dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeria pessoa");
            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Idade: " + p1.Idade);

            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("Idade: " + p2.Idade);

            if (p1.Idade == p2.Idade)
            {
                Console.WriteLine("Ambas possuem a mesma idade");
            } else
            {
                if (p1.Idade > p2.Idade)
                {
                    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
                } else
                {
                    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
                }
            }

        }
    }
}