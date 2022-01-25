using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public class Customer
    {
        private int id;
        private static int nextID = 101;
        public string CustomerName { get; set; }

        public int GetID()
        {
            return id;
        }

        public Customer(string name)
        {
            this.CustomerName = name;
            id = nextID;
            nextID++;
        }
    }
}
