using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankStructure
{
    public abstract class Customer
    {
        public string Id { get; private set; }

        protected Customer(string cutomerId)
        {
            this.Id = cutomerId;
        }
    }
}
