using Hotel.Entities;
using System;
using System.Globalization;

namespace Hotel {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o quarto que deseja alugar: ");
            int numQuarto = int.Parse(Console.ReadLine());
            Console.Write("Insira a data do check-in: ");
            DateTime chekIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Insira a data do check-out: ");
            DateTime chekOut = DateTime.Parse(Console.ReadLine());

            Reservas r = new Reservas(numQuarto, chekIn, chekOut);

            Console.WriteLine(r);
        }
    }
}