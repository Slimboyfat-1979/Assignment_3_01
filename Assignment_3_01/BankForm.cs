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
        private string[] accountNames = { "Everyday", "Investment", "Omni" };
        bool[] buttonClicked = { false, false };
        
        public BankForm(Customer t)
        {
            InitializeComponent();
            this.temp = t;
            label3.Text = + t.GetID() + " " + t.CustomerName;
            listBox1.Items.Clear();
            interestCheckBox.Checked = false;

            //Working on the list iteration for the bankform
            if(interestCheckBox.Checked == false)
            {
                
            foreach(Customer cust in c.GetCustomerNameList())
                {
                    if(t.CustomerName == cust.CustomerName)
                    {
                        listBox1.Items.Add(accountNames[0] + " $" +  cust.GetEverdayAccount().Balance);
                        listBox1.Items.Add(accountNames[1] + " $" + cust.GetInvestmentAccount().Balance);
                        listBox1.Items.Add(accountNames[2] + " $" + cust.GetOmniAccount().Balance);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewAccount newAccount = new AddNewAccount(temp);
            this.Hide();
            newAccount.Show();
        }

        //Deposit
        private void button2_Click(object sender, EventArgs e)
        {
            buttonClicked[0] = true;
            buttonClicked[1] = false;
        }
        //Withdraw
        private void button3_Click(object sender, EventArgs e)
        {
            buttonClicked[1] = true;
            buttonClicked[0] = false;
        }
        //Transfer
        private void button4_Click(object sender, EventArgs e)
        {
            TransferForm f = new TransferForm(temp);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }
        //Save Button
        private void button5_Click(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            double value = Convert.ToDouble(txtValue.Text);
            double balance;

            //Deposit
            if(buttonClicked[0] == true)
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
            if(buttonClicked[1] == true)
            {
                switch (selected)
                {
                    case 0:
                        balance = temp.GetEverdayAccount().Balance;
                        if(c.FailedWithdrawalCheck(value, balance) != true)
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
                        if (c.FailedWithdrawalCheck(value, balance) != true)
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
                        if (c.FailedWithdrawalCheck(value, balance) != true)
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

                
                //Withdrawal
                //if(buttonsClicked[2] == true)
                //{
                //    switch (selected)
                //    {
                //        case 0:
                //            balance = temp.GetEverdayAccount().Balance;
                //            if(c.FailedWithdrawalCheck(value, balance)!= true)
                //            {
                //                temp.GetEverdayAccount().Balance = c.MakeWithdrawal(value, balance);
                //            }
                //            else
                //            {
                //                balance = balance - Account.withdrawalPenalty;
                //                temp.GetEverdayAccount().Balance = balance;
                //                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                //            }
                //            RefreshList();
                //            break;
                //        case 1:
                //            balance = temp.GetInvestmentAccount().Balance;
                //            if(c.FailedWithdrawalCheck(value, balance) != true)
                //            {
                //                temp.GetInvestmentAccount().Balance = c.MakeWithdrawal(value, balance);
                //            }
                //            else
                //            {
                //                balance = balance - Account.withdrawalPenalty;
                //                temp.GetInvestmentAccount().Balance = balance;
                //                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                //            }
                //            RefreshList();
                //            break;
                //        case 2:
                //            balance = temp.GetOmniAccount().Balance;
                //            if(c.FailedWithdrawalCheck(value, balance) != true)
                //            {
                //                temp.GetOmniAccount().Balance = c.MakeWithdrawal(value, balance);
                //            }
                //            else
                //            {
                //                balance = balance - Account.withdrawalPenalty;
                //                temp.GetOmniAccount().Balance = balance;
                //                MessageBox.Show("You do not have enough funds to process this transaction \n You have incurred a $10.00 penalty");
                //            }
                //            RefreshList();
                //            break;
                //    }
                //}
            
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
 

