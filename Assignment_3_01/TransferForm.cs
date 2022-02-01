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
        List<int> counter = new List<int>();
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
           
            string[] name = { "Everyday $", "Investment $", "Omni $" };
            foreach(Account a in accountList)
            {
                fromBoxBalances.Add(a.Balance);
                toBoxBalances.Add(a.Balance);
                listBoxFrom.Items.Add(name[count] + a.Balance);
                listBoxTo.Items.Add(name[count] + a.Balance);
                count++;
                counter.Add(count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BankForm(temp).Show();
        }

        //I need to set the balances in the account from here. 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToInt32(textAmount.Text);
            int selectedAmountFromIndex = listBoxFrom.SelectedIndex;
            int selectedAmountToIndex = listBoxTo.SelectedIndex;

            double amountFrom = fromBoxBalances[selectedAmountFromIndex];
            double amountTo = toBoxBalances[selectedAmountToIndex];

            DialogResult result = MessageBox.Show($"Do you want to transfer from {fromBoxBalances[selectedAmountFromIndex]} to ?", "Confirmation", MessageBoxButtons.YesNoCancel);

            amountFrom = amountFrom - amount;
            amountTo = amountTo + amount;
            // Two Seperate functionalities for this
            accountList[counter[count]].Balance = amountFrom;

            listBoxFrom.Items.Clear();
            listBoxTo.Items.Clear();
            listBoxFrom.Items.Add(amountFrom);
            listBoxTo.Items.Add(amountTo);

           
            
            
        }
    }
}
