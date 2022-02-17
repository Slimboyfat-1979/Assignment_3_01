using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    [Serializable]
    public abstract class Account
    {
        public int AccountIndicator { get; set; }
        public static double interestRate = 4.00;
        public static double withdrawalPenalty = 10;
        public double Balance { get; set; }
        public double BalanceWithInterest { get; set; }
        public string Name { get; set; }

        

        public Account(string name ,double balance, int accountIndicator)
        {
            this.Name = name;
            this.Balance = balance;
            this.AccountIndicator = accountIndicator; 
        }
    }
}
