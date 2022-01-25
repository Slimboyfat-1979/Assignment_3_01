﻿using System;
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
    public partial class AddCustomer : BaseDesign
    {
        Controller c = Home.GetController();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newCustomer = customerEntry.Text;
            c.AddCustomer(newCustomer);
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }
    }
}
