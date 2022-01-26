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
        InvestmentAccount i;
        OmniAccount o;

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
        public Customer(string name, double eBalance, double iBalance, double oBalance)
        {
            this.CustomerName = name;
            id = nextID;
            nextID++;
            SettEverdayAccount(new EverdayAccount(name, eBalance));
            SetInvestmentAccount(new InvestmentAccount(name, iBalance));
            SetOmniAccount(new OmniAccount(name, oBalance));
        }

        public void SetOmniAccount(OmniAccount o)
        {
            this.o = o;
        }

        public OmniAccount GetOmniAccount()
        {
            return this.o;
        }

        public void SetInvestmentAccount(InvestmentAccount i)
        {
            this.i = i;
        }

        public InvestmentAccount GetInvestmentAccount()
        {
            return this.i;
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
