using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    public abstract class Account
    {
        public Customer AccountCustomer { get; private set; }
        public double Balance { get; set; }
        public double InterestRate { get; private set; }

        //Base Constructor
        protected Account(Customer customer, double balance, double interestRate)
        {
            if (interestRate < 0)
            {
                throw new ArgumentException("The effective interest rate cannot be a negative number!");
            }
            if (balance < 0)
            {
                throw new ArgumentException("You cannot create account with negative balance!");
            }
            this.AccountCustomer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //Abstract methods
        public abstract double CalculateInterest(int periodInMonths);
        

    }
}
