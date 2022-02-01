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
    public partial class BankForm : BaseDesign
    {
        Customer temp;
        Controller c = Home.GetController();
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        private bool button3Clicked = false;
        private bool button4Clicked = false;
        
        
        public BankForm(Customer t)
        {
            InitializeComponent();
            this.temp = t;
            label3.Text = + t.GetID() + " " + t.CustomerName;
            listBox1.Items.Clear();
            interestCheckBox.Checked = false;

            if(interestCheckBox.Checked == false)
            {
                
            listBox1.Items.Add("Everyday $" + temp.GetEverdayAccount().Balance);
            listBox1.Items.Add("Investment $" + temp.GetInvestmentAccount().Balance);
            listBox1.Items.Add("Omni $" + temp.GetOmniAccount().Balance);
            
            }
        }
        //Add New Account
        private void button1_Click(object sender, EventArgs e)
        {
        }

        //Deposit
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
            button2Clicked = true;
        }
        //Withdraw
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGray;
            button3Clicked = true;
        }
        //Transfer
        private void button4_Click(object sender, EventArgs e)
        {
            button4Clicked = true;
            button1Clicked = true;
            TransferForm f = new TransferForm(temp);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
    }
        //Save Button
        private void button5_Click(object sender, EventArgs e)
        {
            //Fix this bug
            if (txtValue.Text.Equals("")) 
            {
                MessageBox.Show("Please enter an amount");
            }
            if (button1Clicked == false && button2Clicked == false && button3Clicked == false && button4Clicked == false)
            {
                MessageBox.Show("Please select an action");
            }
            else
            {
                int selected = listBox1.SelectedIndex;
                double value = Convert.ToDouble(txtValue.Text);
                double balance;
                //Deposit
                if (button2Clicked == true)
                {
                    switch (selected)
                    {
                        case 0:
                            balance = temp.GetEverdayAccount().Balance;
                            temp.GetEverdayAccount().Balance = c.MakeDeposit(value, balance);
                            RefreshList();
                            break;
                        case 1:
                            balance = temp.GetInvestmentAccount().Balance;
                            temp.GetInvestmentAccount().Balance = c.MakeDeposit(value, balance);
                            RefreshList();
                            break;
                        case 2:
                            balance = temp.GetOmniAccount().Balance;
                            temp.GetOmniAccount().Balance = c.MakeDeposit(value, balance);
                            RefreshList();
                            break;
                    }
                }
                //Withdrawal
                if(button3Clicked == true)
                {
                    switch (selected)
                    {
                        case 0:
                            balance = temp.GetEverdayAccount().Balance;
                            if(c.FailedWithdrawalCheck(value, balance)!= true)
                            {
                                temp.GetEverdayAccount().Balance = c.MakeWithdrawal(value, balance);
                            }
                            else
                            {
                                balance = balance - Account.withdrawalPenalty;
                                temp.GetEverdayAccount().Balance = balance;
                                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                            }
                            RefreshList();
                            break;
                        case 1:
                            balance = temp.GetInvestmentAccount().Balance;
                            if(c.FailedWithdrawalCheck(value, balance) != true)
                            {
                                temp.GetInvestmentAccount().Balance = c.MakeWithdrawal(value, balance);
                            }
                            else
                            {
                                balance = balance - Account.withdrawalPenalty;
                                temp.GetInvestmentAccount().Balance = balance;
                                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                            }
                            RefreshList();
                            break;
                        case 2:
                            balance = temp.GetOmniAccount().Balance;
                            if(c.FailedWithdrawalCheck(value, balance) != true)
                            {
                                temp.GetOmniAccount().Balance = c.MakeWithdrawal(value, balance);
                            }
                            else
                            {
                                balance = balance - Account.withdrawalPenalty;
                                temp.GetOmniAccount().Balance = balance;
                                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                            }
                            RefreshList();
                            break;
                    }
                }
            }
        }

        public void RefreshList()
        {
            int accountName = 0;
            double[] balances = new double[3];
            string[] name = { "Everyday $", "Investment $","Omni $"};
            listBox1.Items.Clear();
            List<Account> accounts = temp.GetAccounts();
            foreach (Account a in accounts)
            {
                
                balances[accountName] = a.Balance;
                accountName++;
            }

            for(int i = 0; i < balances.Length; i++)
            {
                listBox1.Items.Add(name[i]  + balances[i]);
            }
         }

        
        // Cancel Button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerForm().Show();
        }

        private void interestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(interestCheckBox.Checked == true)
            {
                List<Account> accounts = temp.GetAccounts();
                List<double> balance = new List<double>();
                List<double> interest = new List<double>();
                List<double> balanceWithInterest = new List<double>();
                string[] name = { "Everyday $", "Investment $", "Omni $" };

                //Get the balances
                foreach (Account a in accounts)
                {
                    balance.Add(a.Balance);
                }

                //Get the interest from those balances
                listBox1.Items.Clear();
                foreach (double d in balance)
                {
                    interest.Add(c.GetBalanceWithInterest(d));
                }

                int count = 0;
                while (count < balance.Count)
                {
                    double sum = balance[count] + interest[count];
                    balanceWithInterest.Add(sum);
                    count++;
                }

                //Write out labels here
                /*
                foreach (double d in balanceWithInterest)
                {

                    listBox1.Items.Add(d);
                }
                */

                for(int i = 0; i < balanceWithInterest.Count; i++)
                {
                    listBox1.Items.Add(name[i] + balanceWithInterest[i]);
                }
            }

            if(interestCheckBox.Checked == false)
            {
                RefreshList();
            }
        }
    }
}
 

