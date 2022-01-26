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
            listBox1.Items.Add("Everyday $" + temp.GetEverdayAccount().Balance);
            listBox1.Items.Add("Investment $" + temp.GetInvestmentAccount().Balance);
            listBox1.Items.Add("Omni $" + temp.GetOmniAccount().Balance);
            
            
        }
        //Add New Account
        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
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
            button3Clicked = true;
        }
        //Transfer
        private void button4_Click(object sender, EventArgs e)
        {
            button4Clicked = true;
        }
        //Save Button
        private void button5_Click(object sender, EventArgs e)
        {
            if (button1Clicked == false && button2Clicked == false && button3Clicked == false && button4Clicked == false)
            {
                MessageBox.Show("Please select an action");
            }
            else
            {
                int selected = listBox1.SelectedIndex;
                double value = Convert.ToDouble(txtValue.Text);
                double balance;
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
                    }
                }
            }
        }

        public void RefreshList()
        {
            int accountName = 0;
            double[] balances = new double[3];
            string[] name = { "Everday $", "Investment $","Omni $"};
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
    }
 }

