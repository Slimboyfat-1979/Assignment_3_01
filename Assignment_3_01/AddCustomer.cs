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
    [Serializable]
    public partial class AddCustomer : BaseDesign
    {
        Controller c = Home.GetController();
        int[] accountTypeIndicator = {0,1,2};
        double eBalance;
        double iBalance;
        double oBalance;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newCustomer = customerEntry.Text;
            eBalance = Convert.ToInt32(eBalanceText.Text);
            iBalance = Convert.ToInt32(IBalanceText.Text);
            oBalance = Convert.ToInt32(OBalanceText.Text);
            c.AddCustomer(newCustomer, eBalance, iBalance, oBalance, accountTypeIndicator);

            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }
    }
}
