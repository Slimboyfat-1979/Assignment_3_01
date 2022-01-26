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
    public partial class BankForm : BaseDesign
    {
        Customer temp;
        public BankForm(Customer t)
        {
            InitializeComponent();
            this.temp = t;
            label3.Text = + t.GetID() + " " + t.CustomerName;
            listBox1.Items.Clear();
            listBox1.Items.Add("Everyday $" + temp.GetEverdayAccount().Balance);
            listBox1.Items.Add("Investment $ " + temp.GetInvestmentAccount().Balance);
            listBox1.Items.Add("Omni $" + temp.GetOmniAccount().Balance);
            
        }
    }
}
