using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ATM.Model;

namespace ATM.Data
{
    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATM")
        {

        }

        public DbSet<DepositAccount> DepositAccounts { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }
    }
}
