using ExemploProduto;
using System.Globalization;

namespace ExemploProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();

            p1.EntradaDados();
            Console.WriteLine(p1.ToString());

            Console.WriteLine();
            Console.Write("Insira a quantidade a ser adicionada do estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qtd);
            Console.WriteLine("Dados do Produto: " + p1);

            Console.WriteLine();
            Console.Write("Insira a quantidade a ser removida do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qtd);
            Console.WriteLine("Dados do Produto: " + p1);
        }   
    }
}