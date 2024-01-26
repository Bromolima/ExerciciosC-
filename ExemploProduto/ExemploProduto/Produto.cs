using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto() { }

        public Produto(int qtd)
        {
            Qtd = qtd;
        }

        public Produto(string nome, double preco, int qtd) : this(qtd)
        {
            Nome = nome;
            Preco = preco;
        }

        public string nome
        {
            get { return Nome; }
            set
            {
                if(value != null)
                {
                    Nome = value;
                }
            }
        }

        public void EntradaDados()
        {
            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: "); nome = Console.ReadLine();
            Console.Write("Preço: ");  Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");  Qtd = int.Parse(Console.ReadLine());
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int qtd)
        {
            Qtd += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Qtd -= qtd;
        }

        public override string ToString()
        {
            return Nome
                   + ", $"
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Qtd
                   + " Unidades, Total: $"
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
