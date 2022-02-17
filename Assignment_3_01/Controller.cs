using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_01
{
    /// <summary>
    ///  Represents the controller class for all base functionality within the app
    /// </summary>
    public class Controller
    {
        public List<Customer> customerNameList = new List<Customer>();

       /// <summary>
       /// Retrives the customer list
       /// </summary>
       /// <returns>Returns the customer list</returns>
        public List<Customer> GetCustomerNameList()
        {
            return customerNameList;
        }

        /// <summary>
        /// Returns a specific customer
        /// </summary>
        /// <param name="index">This is the index that is passed from any class that needs the method</param>
        /// <returns>Returns a customer</returns>
        public Customer GetCustomer(int index)
        {
            return customerNameList[index];
        }

        /// <summary>
        /// Adds a customer to the customerlist
        /// </summary>
        /// <param name="name">The name of the customer</param>
        /// <param name="eBalance">The balance for the everyday account</param>
        /// <param name="iBalance">The balance for the investment account</param>
        /// <param name="oBalance">The balance for the omni account</param>
        /// <param name="accountTypeIndicator">This is an array to indicate what type of account is being made</param>
        public void AddCustomer(string name, double eBalance, double iBalance, double oBalance, int[] accountTypeIndicator)
        {
            customerNameList.Add(new Customer(name, eBalance, iBalance, oBalance, accountTypeIndicator));
        }

        /// <summary>
        /// This looks for a customer given a specific paremeter using a name
        /// </summary>
        /// <param name="name">The name that is passed</param>
        /// <param name="c">The customer object that is being passed</param>
        public void SearchCustomer(string name, Customer c)
        {
            if (customerNameList.Contains(c))
            {
                c.CustomerName = name;
            }
        }
        /// <summary>
        /// This deletes a customer object from the customerList
        /// </summary>
        /// <param name="c">The customer object to be deleteled</param>
        public void DeleteCustomer(Customer c)
        {
            if (customerNameList.Contains(c))
            {
                customerNameList.Remove(c);
            }
        }

        /// <summary>
        /// This is the method to make a deposit
        /// </summary>
        /// <param name="value">The value to change the balance</param>
        /// <param name="balance">The current balance</param>
        /// <returns></returns>
        public double MakeDeposit(double value, double balance)
        {
            balance = balance + value;
            return balance;
        }

        /// <summary>
        /// This is the method to create a withdrawal
        /// </summary>
        /// <param name="value">The value to change the balance</param>
        /// <param name="balance">The current balance</param>
        /// <returns></returns>
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

        /// <summary>
        /// This checks whether there is enough funds in the account
        /// </summary>
        /// <param name="value">The value passed in</param>
        /// <param name="balance">The balance that is passed in</param>
        /// <returns>a boolean of true if failed, and false if succeeded</returns>
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
        /// <summary>
        /// This calculates how much interest for each balance at a rate set in the account class
        /// </summary>
        /// <param name="value">The valud passed in</param>
        /// <returns>Returns the new balance with the interest calculated</returns>
        public double GetBalanceWithInterest(double value)
        {
            
            double newBalance = value * (Account.interestRate / 100);
            return newBalance;
        }

    }
}
