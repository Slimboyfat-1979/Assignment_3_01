using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    public class Controller
    {
        //THIS IS THE LIST TO ITERATE THROUGH
        public List<Customer> customerNameList = new List<Customer>();

        //Use this to get the customerslist with all the information available
        public List<Customer> GetCustomerNameList()
        {
            return customerNameList;
        }

        public Customer GetCustomer(int index)
        {
            return customerNameList[index];
        }

        //Adds a customer
        public void AddCustomer(string name, double eBalance, double iBalance, double oBalance, int[] accountTypeIndicator)
        {
            customerNameList.Add(new Customer(name, eBalance, iBalance, oBalance, accountTypeIndicator));
        }

        //Edits a customer
        public void SearchCustomer(string name, Customer c)
        {
            if (customerNameList.Contains(c))
            {
                c.CustomerName = name;
            }
        }
        //Delete Customer
        public void DeleteCustomer(Customer c)
        {
            if (customerNameList.Contains(c))
            {
                customerNameList.Remove(c);
            }
        }

        //Deposit
        public double MakeDeposit(double value, double balance)
        {
            balance = balance + value;
            return balance;
        }

        //Basic Withdrawal possible multple overloaded methods depending
        public double MakeWithdrawal(double value, double balance)
        {
            if(value > balance)
            {
                //return a warning
                return -1;
            }
            else
            {
               return balance -= value;
            }
        }

        public bool FailedWithdrawalCheck(double value, double balance)
        {
            if(value > balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetBalanceWithInterest(double value)
        {
            
            double newBalance = value * (Account.interestRate / 100);
            return newBalance;
        }

    }
}
