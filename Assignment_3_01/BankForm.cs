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
        public BankForm(Customer t)
        {
            InitializeComponent();
            this.temp = t;
            label3.Text = + t.GetID() + " " + t.CustomerName;
        }
    }
}
