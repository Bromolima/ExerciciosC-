using System;

namespace Excecoes {
    class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int res = n1 / n2;
                Console.WriteLine(res);

            } catch(DivideByZeroException e) {
                Console.WriteLine("Não é possível dividir por 0");
            } catch (FormatException e) {
                Console.WriteLine("Erro de formato" + e.Message);
            }
        } 
    }
}