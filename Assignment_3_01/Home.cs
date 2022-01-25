using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_01
{
    public partial class Home : BaseDesign
    {
        private static Controller control = new Controller();

        //Use this method to get the controller used for all classes etc
        public static Controller GetController()
        {
            return control;
        }
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadInitialCustomers();
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
            
        }

        public void LoadInitialCustomers()
        {
            string[] customerArray;
            StreamReader reader = new StreamReader("/Data.txt");
            Customer c;
            while (!reader.EndOfStream)
            {
                customerArray = reader.ReadLine().Split();
                c = new Customer(customerArray[0]);
                control.customerNameList.Add(c);
            
            }
        }
    }
}
