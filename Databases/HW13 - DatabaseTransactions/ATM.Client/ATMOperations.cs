using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ATM.Data;
using ATM.Model;

namespace ATM.Client
{
    class ATMOperations
    {
        public static bool WithdrawMoney(int pin, long cardNumber, decimal moneyToWithdraw, ATMContext db)
        {
            bool success = true;
            long cardNumberToRecord = 0;


            using (var scope = new TransactionScope(
                        TransactionScopeOption.RequiresNew,
                        new TransactionOptions()
                        {
                            IsolationLevel = IsolationLevel.RepeatableRead
                        }
                    ))
            {
                var card = (from c in db.DepositAccounts
                            where c.CardNumber == cardNumber
                            select c).First();


                if (card == null || card.CardPIN != pin || card.Balance < moneyToWithdraw)
                {
                    success = false;
                }
                else
                {
                    card.Balance -= moneyToWithdraw;
                    cardNumberToRecord = card.CardNumber;
                    scope.Complete();
                }
            }

            if (success)
            {
                RecordWithdrawal(cardNumberToRecord, moneyToWithdraw, db);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void RecordWithdrawal(long cardNumber, decimal ammount, ATMContext db)
        {
            using (var scope = new TransactionScope(
                        TransactionScopeOption.RequiresNew,
                        new TransactionOptions()
                        {
                            IsolationLevel = IsolationLevel.RepeatableRead
                        }))
            {
                db.TransactionLogs.Add(new TransactionLog()
                {
                    TransactionDate = DateTime.Now,
                    Ammount = ammount,
                    CardNumber = cardNumber
                });
                scope.Complete();
            }

        }

        public static void ShowCards()
        {
            using (ATMContext db = new ATMContext())
            {
                foreach (var item in db.DepositAccounts)
                {
                    Console.WriteLine("AccountID:{0}, Balance: {1}", item.Id, item.Balance);
                }
            }
        }
    }
}
