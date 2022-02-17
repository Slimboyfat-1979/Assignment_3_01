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
    public partial class CustomerForm : BaseDesign
    {
        Controller c = Home.GetController();
        public CustomerForm()
        {
            InitializeComponent();
            RefreshList();
        }

        public void RefreshList()
        {
            
            lstBoxCustomers.Items.Clear();
            lstBoxCustomers.Items.Add("ID\tName");
            foreach (Customer customer in c.customerNameList)
            {
                lstBoxCustomers.Items.Add(customer.GetID() + "\t" + customer.CustomerName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedCustomer = lstBoxCustomers.SelectedIndex-1;
            Customer temp = c.GetCustomer(selectedCustomer);
            this.Hide();
            EditCustomer editCustomer = new EditCustomer(temp);
            editCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedCustomer = lstBoxCustomers.SelectedIndex - 1;
            Customer temp = c.GetCustomer(selectedCustomer);
            DialogResult dialogResult = MessageBox.Show("Would you like to remove customer: " + temp.CustomerName + "?", "Remove Customer?", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                c.DeleteCustomer(temp);
                RefreshList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            int seletedCustomer = lstBoxCustomers.SelectedIndex;
            Customer temp = c.GetCustomer(seletedCustomer-1);
            BankForm bankForm = new BankForm(temp);
            this.Hide();
            bankForm.Show();
            
        }
    }
}
