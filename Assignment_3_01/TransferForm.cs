using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_01
{
    public partial class TransferForm : BaseDesign
    {

        List<double> fromBoxBalances = new List<double>();
        List<double> toBoxBalances = new List<double>();
        Controller c = Home.GetController();
        Customer temp;
        int count = 0;
        string[] nameOfAccounts = { "Everday $", "Investment $", "Omni $" };
       
        //Get balances of accounts
        List<Account> accountList;
        
        public TransferForm(Customer t)
        {
            InitializeComponent();
            temp = t;
            accountList = t.GetAccounts();
            RefreshListBox();
        }

        public void RefreshListBox()
        {
           
            foreach(Account a in accountList)
            {
                listBoxFrom.Items.Add(nameOfAccounts[count] + a.Balance);
                listBoxTo.Items.Add(nameOfAccounts[count] + a.Balance);
                fromBoxBalances.Add(a.Balance);
                toBoxBalances.Add(a.Balance);
                //Need this to keep track of how many balances there are
                //CounterOfBalances = number of balances count is the label count of the accounts
                
                count++;
            }


            //string[] name = { "Everyday $", "Investment $", "Omni $" };
            //foreach(Account a in accountList)
            //{
            //    fromBoxBalances.Add(a.Balance);
            //    toBoxBalances.Add(a.Balance);
            //    listBoxFrom.Items.Add(name[count] + a.Balance);
            //    listBoxTo.Items.Add(name[count] + a.Balance);
            //    count++;
            //    counterTo.Add(count);
            //    counterFrom.Add(count);
            //}
            //count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BankForm(temp).Show();
        }

        //I need to set the balances in the account from here. 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            count = 0;
            double amountToTransfer = Convert.ToDouble(textAmount.Text);
            
            int selectedIndexFrom = listBoxFrom.SelectedIndex;
            int selectedIndexTo = listBoxTo.SelectedIndex;

            double amountF = fromBoxBalances[selectedIndexFrom];
            double amountT = toBoxBalances[selectedIndexTo];

            amountF -= amountToTransfer;
            amountT += amountToTransfer;

            fromBoxBalances[selectedIndexFrom] = amountF;
            toBoxBalances[selectedIndexTo] = amountT;

            accountList[selectedIndexFrom].Balance = amountF;
            accountList[selectedIndexTo].Balance = amountT;

            listBoxFrom.Items.Clear();
            listBoxTo.Items.Clear();

            foreach (Account a in accountList)
            {
                listBoxFrom.Items.Add(nameOfAccounts[count] + a.Balance);
                listBoxTo.Items.Add(nameOfAccounts[count] + a.Balance);
                count++;
            }
        }
    }
}
