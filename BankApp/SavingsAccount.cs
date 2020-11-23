using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingsAccount: Account
    {
        public List<Transaction> Transactions { get; set; }
        public override void Deposit(double amount)
        {
            balance = +amount;
        }

        public override void Withdraw(double amount)
        {
            if(amount < balance)
            {
                if (balance > 500)
                {
                    balance -= amount;
                }
                else
                    Console.WriteLine("Blance is less than 500tk");
            }
            else
                Console.WriteLine("Insufficient balance");
        }
        public override void Transactions(double amount, string accID)
        {
            balance += amount;


        }

    }
}
