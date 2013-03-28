using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, double balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
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

            double result = 0;

            if (this.AccountCustomer is Individual)
            {
                periodInMonths -= 6;
                if (periodInMonths < 0) periodInMonths = 0;
                result = periodInMonths * this.InterestRate;
            }
            else if (this.AccountCustomer is Company)
            {                
                if (periodInMonths < 12)
                {
                    result = periodInMonths * this.InterestRate / 2.0;
                }
                else
                {
                    result = (12 * this.InterestRate / 2.0) + (periodInMonths - 12) * this.InterestRate;
                }
            }
            
            return result;
        }
    }
}
