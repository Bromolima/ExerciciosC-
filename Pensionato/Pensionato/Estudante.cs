using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Estudante
    {
        public string Email { get; set; }
        public string Nome { get; set; }

        public Estudante() { }
        public Estudante(string email, string nome)
        {
            Email = email;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
