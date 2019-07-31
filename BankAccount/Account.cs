using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents an individual bank account
    /// </summary>
    public class Account
    {
        public string AccountNumber { get; set; }

        public string Owner { get; set; }

        public double Balance { get; private set; }

        /// <summary>
        /// Adds an amount to the current balance and returns
        /// the updated balance
        /// </summary>
        /// <param name="amt">The amount being deposited</param>
        public double Deposit(double amt)
        {
            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amt">The amount being withdrawn</param>
        public double Withdraw(double amt)
        {
            Balance -= amt;
            return Balance;
        }
    }
}
