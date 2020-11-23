using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    abstract class Account
    {
        private string accName;
        private string accID;
        protected double balance;

        public string AccName
        {
            get {return accName;}
            set { value = accName;}
        }
        public string AccID
        {
             get { return accID; }
             set { value = accID; }
        }
        public double Balance
        {
              get { return balance; }
              set { value = balance; }
        }
        public Account() { }
        public Account(string accName, string accID, double balance)
        {
            this.accName = accName;
            this.accID = accID;
            this.balance = balance;
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void Transactions(double amount, string accID);

        virtual public void ShowInfo()
        {
            Console.WriteLine("Name: " +accName);
            Console.WriteLine("AccNo: " +accID);
            Console.WriteLine("Balance: " +balance);
        }
    }
}
