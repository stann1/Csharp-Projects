using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, double balance, double interestRate)
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

            if (this.AccountCustomer is Individual)
            {
                periodInMonths -= 3;
            }
            else if(this.AccountCustomer is Company)
            {
                periodInMonths -= 2;
            }

            if (periodInMonths < 0) periodInMonths = 0;
            
            double result = periodInMonths * this.InterestRate;
            return result;
        }
    }
}
