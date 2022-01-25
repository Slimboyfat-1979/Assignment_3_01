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
            foreach(Customer customer in c.customerNameList)
            {
                lstBoxCustomers.Items.Add(customer.CustomerName);
            }
        }
    }
}
