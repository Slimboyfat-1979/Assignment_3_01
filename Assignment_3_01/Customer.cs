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

        //Name, amount, account indicator
        private List<Account> accountList = new List<Account>();

        private int id;
        private static int nextID = 101;
        public string CustomerName { get; set; }

        public int GetID()
        {
            return id;
        }

        public List<Account> GetAccounts()
        {
            return accountList;
        }


        public Customer(string name)
        {
            this.CustomerName = name;
            id = nextID;
            nextID++;
        }

        //Could add more references for the other accounts here
        public Customer(string name, double eBalance, double iBalance, double oBalance, int[] accountIndicator) : this(name)
        {

            SetEverdayAccount(new EverdayAccount(name, eBalance, accountIndicator[0]));
            SetInvestmentAccount(new InvestmentAccount(name, iBalance, accountIndicator[1]));
            SetOmniAccount(new OmniAccount(name, oBalance, accountIndicator[2]));

        }

        public void SetOmniAccount(OmniAccount o)
        {
            this.o = o;
            accountList.Add(this.o);
        }

        public OmniAccount GetOmniAccount()
        {
            return this.o;
        }

        public void SetInvestmentAccount(InvestmentAccount i)
        {
            this.i = i;
            accountList.Add(this.i);
        }

        public InvestmentAccount GetInvestmentAccount()
        {
            return this.i;
        }

        public void SetEverdayAccount(EverdayAccount e)
        {
            this.e = e;
            accountList.Add(this.e);
        }

        public EverdayAccount GetEverdayAccount()
        {
            return this.e;
        }
    }
}
