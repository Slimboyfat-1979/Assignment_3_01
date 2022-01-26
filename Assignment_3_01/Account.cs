using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public string Name { get; set; }

        public Account(string name ,double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
    }
}
