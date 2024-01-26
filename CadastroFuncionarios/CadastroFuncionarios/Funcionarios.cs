using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios() { }

        public Funcionarios(int id)
        {
            Id = id;
        }

        public Funcionarios(int id, string nome, double salario) : this(id)
        {
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double tax)
        {
            Salario += Salario * tax;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", " + Nome + ", salario: $" + Salario;
        }
    }
}
