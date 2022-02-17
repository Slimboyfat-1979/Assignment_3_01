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
    public partial class AddNewAccount : BaseDesign
    {
        Customer temp;
        int accountTypeIndicator;
        public AddNewAccount(Customer t)
        {
            
            this.temp = t;
            InitializeComponent();
            label5.Text = "For Customer: " + t.CustomerName;
        }
        //Adding new account here
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedAccount = accountComboBox.SelectedIndex;
            double amount = Convert.ToDouble(textAmount.Text);
            string[] accountNames = { "Everyday", "Investment", "Omni" };
            string accountName = "";
            switch (selectedAccount)
            {
                case 0:
                    //Do something here
                    accountTypeIndicator = 0;
                    temp.SetEverdayAccount(new EverdayAccount(temp.CustomerName, amount, accountTypeIndicator));
                    accountName = accountNames[selectedAccount];
                    break;
                case 1:
                    //Do something here
                    accountTypeIndicator = 1;
                    temp.SetInvestmentAccount(new InvestmentAccount(temp.CustomerName, amount, accountTypeIndicator));
                    accountName = accountNames[selectedAccount];
                   
                    break;
                case 2:
                    accountTypeIndicator = 2;
                    temp.SetOmniAccount(new OmniAccount(temp.CustomerName, amount, accountTypeIndicator));
                    accountName = accountNames[selectedAccount];
                   
                    //Do something here
                    break;
            }
            MessageBox.Show($"A new {accountName} account has been created for {temp.CustomerName} with a balance of ${Convert.ToString(amount)}");
            this.Hide();
            new BankForm(temp).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BankForm(temp).Show();
        }
    }
}
