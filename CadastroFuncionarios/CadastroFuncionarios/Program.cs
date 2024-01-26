using System.Globalization;

namespace CadastroFuncionarios
{
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários irá cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário[" + (i + 1) + "]");
                Console.Write("Id: "); int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: "); string nome = Console.ReadLine();
                Console.Write("Salario: "); double salario = double.Parse(Console.ReadLine());
                Funcionarios f = new Funcionarios(id, nome, salario);
                list.Add(f);
            }

            foreach(Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.Write("Insira o id do funcionário que terá o salário aumentado: ");
            int tempId = int.Parse(Console.ReadLine());
            if (list.Exists(x => x.Id == tempId))
            {
                Funcionarios tempF = list.Find(x => x.Id == tempId);
                Console.Write("Insira a porcentagem: ");
                double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                tempF.AumentoSalario(tax);
            } else
            {
                Console.WriteLine("Id não existe");
            }

            foreach(Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }

}

