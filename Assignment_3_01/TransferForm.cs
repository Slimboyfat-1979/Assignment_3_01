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
        DialogResult messages;
        Customer temp;
        int count = 0;
        string[] nameOfAccounts = { "Everday", "Investment", "Omni" };
       
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
                listBoxFrom.Items.Add(nameOfAccounts[count] + " $"  + a.Balance);
                listBoxTo.Items.Add(nameOfAccounts[count] + " $" + a.Balance);
                fromBoxBalances.Add(a.Balance);
                toBoxBalances.Add(a.Balance);
                count++;
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
            count = 0;
            double amountF;
            double amountT;
            double amountToTransfer;

            int selectedIndexFrom = listBoxFrom.SelectedIndex;
            int selectedIndexTo = listBoxTo.SelectedIndex;

            if (listBoxFrom.SelectedIndex == -1 || listBoxTo.SelectedIndex == -1)
            {
                messages = MessageBox.Show("You need to select an account to transfer from and an account to transfer to");
            }
            else
            {
                if(textAmount.Text == "")
                {
                    messages = MessageBox.Show("You need to enter a value to transfer");
                }
                else
                {
                    amountToTransfer = Convert.ToDouble(textAmount.Text);
                    amountF = fromBoxBalances[selectedIndexFrom];
                    amountT = toBoxBalances[selectedIndexTo];
                    messages = MessageBox.Show($"Would you like to transfer ${amountToTransfer} \n from your {nameOfAccounts[selectedIndexFrom]} account to your {nameOfAccounts[selectedIndexTo]} account?", "No", MessageBoxButtons.YesNoCancel);
                    if (messages == DialogResult.Yes)
                    {
                        textAmount.Text = "";
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
                            listBoxFrom.Items.Add(nameOfAccounts[count] + " $" + a.Balance);
                            listBoxTo.Items.Add(nameOfAccounts[count] + " $" + a.Balance);
                            count++;
                        }
                    }
                }  
            }
        }
    }
}
