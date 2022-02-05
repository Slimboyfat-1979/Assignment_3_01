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
                    temp.SettEverdayAccount(new EverdayAccount(temp.CustomerName, amount));
                    accountName = accountNames[selectedAccount];
                    break;
                case 1:
                    //Do something here
                    temp.SetInvestmentAccount(new InvestmentAccount(temp.CustomerName, amount));
                    accountName = accountNames[selectedAccount];
                    break;
                case 2:
                    temp.SetOmniAccount(new OmniAccount(temp.CustomerName, amount));
                    accountName = accountNames[selectedAccount];
                    //Do something here
                    break;
            }
            MessageBox.Show($"A new {accountName} account has been created for {temp.CustomerName} with a balance of ${Convert.ToString(amount)}");
            this.Hide();
            new BankForm(temp).Show();
        }
    }
}
