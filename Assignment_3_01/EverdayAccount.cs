using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public class EverdayAccount : Account
    {
        Controller c = Home.GetController();
        public EverdayAccount(string name, double balance) : base(name, balance)
        {
        
        }

        /*
        public override void Deposit(double value, double balance)
        {
            c.MakeDeposit(value, balance);
        }
        */
       
    }
}
