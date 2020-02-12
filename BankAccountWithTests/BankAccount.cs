using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithTests
{
    public class BankAccount
    {
        // Field
        private string accountNumber;
        // Constructor
        public BankAccount(string accNum) : this(accNum, 0) { }

        public BankAccount(string accNum, double initialBal)
        {
            AccountNumber = accNum;
            Balance = initialBal;
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Account Number cannot be null or whitespace");
                }
                accountNumber = value;
            }
        }


        public string Owner { get; set; }

        public double Balance { get; private set; }

        /// <summary>
        /// Deposits a positive amount of money into the account and
        /// returns the new balance
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when amt is 0 or less</exception>
        /// <param name="amt">The amount of money to deposit</param>
        public double Deposit(double amt)
        {
            if(amt <= 0)
            {
                throw new ArgumentException("You must deposit a positive amount");
            }
            Balance += amt;
            return Balance;
        }

        public void Withdraw(double amt)
        {
            Balance -= amt;
        }
    }
}
