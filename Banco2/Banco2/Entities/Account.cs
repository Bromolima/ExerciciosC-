using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco2.Entities.Exceptions;

namespace Banco2.Entities {
    internal class Account {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account (int number, string name, double balance, double withDrawLimit) {
            if (withDrawLimit < 0) {
                throw new DomainException("The Limit must be a positive valor");
            }

            Number = number;
            Name = name;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount) {
            if (amount > 0) {
                throw new DomainException("The amount must be a positive valor");
            }
            Balance += amount;
        }

        public void Withdraw (double amount) {
            if (amount > Balance) {
                throw new DomainException("The amount withdrawed must be smaller than you current balance");
            }
            if(amount < 0) {
                throw new DomainException("The amount must be a positive valor");
            }
            if(amount > WithDrawLimit) {
                throw new DomainException("Withdraw limit exceeded");
            }

            Balance -= amount;
        }

        public override string ToString() {
            return "Account number " + Number + ", holder " + Name + ", current balance: $" + Balance + ", limit: $" + WithDrawLimit;
        }
    }
}
