using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; private set; }
        private double Saldo { get; set; }

        public Conta()
        {
            Saldo = 0;
        }

        public Conta(int numeroConta, string nome, double dinheiroCorrente)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = dinheiroCorrente;
        }

        public void Deposito()
        {
            Console.Write("Insira o valor a depositar: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo += deposito;
        }

        public void Saque()
        {
            Console.Write("Insira o valor a sacar: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo -= saque + 5;
        }

        public void Cadastro()
        {
            Console.WriteLine("Insira os seu dados: ");
            Console.Write("Nome: "); Nome = Console.ReadLine();
            Console.Write("Numero da conta: "); NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja fazer um depósito inicial(s/n)?"); string temp = Console.ReadLine();

            if (temp == "s")
            {
                Deposito();
            }
        }

        public override string ToString()
        {
            return Nome + ", " + NumeroConta + ", $" + Saldo;
        }
    }
}
