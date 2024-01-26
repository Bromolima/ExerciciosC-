using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entities {
    internal class Reservas {
        public int NumQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservas() { }

        public Reservas(int numQuarto, DateTime checkIn, DateTime checkOut) {
            NumQuarto = numQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao() {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public override string ToString() {
            return "Quarto " + NumQuarto + ", Check in: " + CheckIn + ", Check out: " + CheckOut;
        }
    }
}
