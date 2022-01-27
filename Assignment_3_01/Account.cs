using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public abstract class Account
    {
        public static double interestRate = 4.00;
        public static double withdrawalPenalty = 10;
        public double Balance { get; set; }
        public double BalanceWithInterest { get; set; }
        public string Name { get; set; }

        //public abstract void Deposit(double value, double balance);

        public Account(string name ,double balance)
        {
            this.Name = name;
            this.Balance = balance;
            double balanceWithInterest = GetInterestRate(balance, interestRate);
            this.BalanceWithInterest = balance + balanceWithInterest;
            
        }
        public double GetInterestRate(double value, double rate)
        {
            double newBalance = value * (rate / 100);
            return newBalance;
        }
    }
}
