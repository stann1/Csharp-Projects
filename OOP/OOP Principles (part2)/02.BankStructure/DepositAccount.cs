using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    class DepositAccount : Account, IDrawable, IDepositable
    {
        public DepositAccount(Customer customer, double balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        //Methods
        public void WithdrawMoney(double sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("You cannot withdraw a negative amount!");
            }
            if (this.Balance - sum < 0)
            {
                Console.WriteLine("Insufficient balance, the maximum sum you can withdraw is: {0}", this.Balance);
            }
            else
            {
                this.Balance -= sum;
            }

        }
        
        public void DepositMoney(double sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("You cannot deposit a negative amount!");
            }
            this.Balance += sum;
        }       
        
        //Overridden method
        public override double CalculateInterest(int periodInMonths)
        {
            if (periodInMonths < 1)
            {
                throw new ArgumentException("The number of months should be a positive integer number");
            }

            if (this.Balance < 1000)
            {
                return 0;
            }
            else
	        {
                double result = periodInMonths * this.InterestRate;
                return result;
	        }
           
        }
    }
}
