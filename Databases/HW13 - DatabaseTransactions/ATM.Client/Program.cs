using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ATM.Data;
using ATM.Data.Migrations;
using ATM.Model;

namespace ATM.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());

            ATMOperations.ShowCards();

            int pin = 1111;
            long cardNumber = 2222222222;
            decimal moneyToWithdraw = 700m;

            using (ATMContext db = new ATMContext())
            {
                if (ATMOperations.WithdrawMoney(pin, cardNumber, moneyToWithdraw, db))
                {
                    Console.WriteLine("Successfully withdrawn {0} leva, from account: {1}", moneyToWithdraw, cardNumber);
                }
                else
                {
                    Console.WriteLine("Transaction could not be completed, insufficient balance");
                }
            }


            Console.WriteLine("Balance after withdraw: ");
            ATMOperations.ShowCards();
        }
    }
}
