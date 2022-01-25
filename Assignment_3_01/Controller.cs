using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public class Controller
    {
        public List<Customer> customerNameList = new List<Customer>();

        //Create temporaray customer for those methods that need it
        Customer temp;

        public Customer GetCustomer(int index)
        {
            return customerNameList[index];
        }

        //Adds a customer
        public void AddCustomer(string name)
        {
            customerNameList.Add(new Customer(name));
        }

        //Edits a customer
        public void SearchCustomer(string name, Customer c)
        {
            if (customerNameList.Contains(c))
            {
                c.CustomerName = name;
            }
        }

    }
}
