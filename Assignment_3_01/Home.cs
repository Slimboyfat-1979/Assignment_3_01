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
        int[] accountTypes = new int[3];

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
            //LoadInitialCustomers();
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
            
        }

        public void LoadInitialCustomers()
        {
            string[] customerArray = null;
            
            StreamReader reader = new StreamReader("/Data2.txt");
            Customer c;
            while (!reader.EndOfStream)
            {
                customerArray = reader.ReadLine().Split(',');
                LoadAccountTypes(customerArray);
                control.AddCustomer(customerArray[0], Convert.ToDouble(customerArray[2]), Convert.ToDouble(customerArray[4]), Convert.ToDouble(customerArray[6]),accountTypes);
            }
        }

        public void LoadAccountTypes(string[] customerArray)
        {
            accountTypes[0] = Convert.ToInt32(customerArray[1]);
            accountTypes[1] = Convert.ToInt32(customerArray[3]);
            accountTypes[2] = Convert.ToInt32(customerArray[5]);
        }
    }
}
