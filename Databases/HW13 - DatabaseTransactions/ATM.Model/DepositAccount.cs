using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    public class DepositAccount
    {
        public int Id { get; set; }

        public long CardNumber { get; set; }

        public int CardPIN { get; set; }

        public decimal Balance { get; set; }
    }
}
