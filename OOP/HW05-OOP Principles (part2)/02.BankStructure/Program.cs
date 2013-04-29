using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            DepositAccount depositAcc = new DepositAccount(new Individual("12A"), 130, 6);

            depositAcc.DepositMoney(1400);
            Console.WriteLine(depositAcc.Balance);
            
            Console.WriteLine(depositAcc.CalculateInterest(8));
        }
    }
}
