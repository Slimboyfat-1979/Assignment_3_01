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
    public partial class EditCustomer : BaseDesign
    {
        Controller c = Home.GetController();
        Customer temp;
        public EditCustomer(Customer t)
        {
            InitializeComponent();
            this.temp = t;
            label2.Text = "Enter new details for: " + t.CustomerName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerEdit = customerEditEntry.Text;
            c.SearchCustomer(customerEdit, temp);
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            
        }
    }
}
