using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public class Customer
    {
        EverdayAccount e;
        private int id;
        private static int nextID = 101;
        public string CustomerName { get; set; }

        public int GetID()
        {
            return id;
        }

        public Customer(string name)
        {
            this.CustomerName = name;
            id = nextID;
            nextID++;
        }

        //Could add more references for the other accounts here
        public Customer(string name, double balance)
        {
            this.CustomerName = name;
            SettEverdayAccount(new EverdayAccount(name, balance));
        }

        public void SettEverdayAccount(EverdayAccount e)
        {
            this.e = e;
        }

        public EverdayAccount GetEverdayAccount()
        {
            return this.e;
        }
    }
}
