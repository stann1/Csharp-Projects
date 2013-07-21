using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Data;
using System.Data.Linq;

namespace _08.ExtendedEmployee
{
    public partial class Employees
    {
        private EntitySet<Territory> entityTerritories;

        public EntitySet<Territory> EntityTerritories
        {
            get
            {
                var employeeTerritories = this.EntityTerritories;
                EntitySet<Territory> entityTerritories = new EntitySet<Territory>();
                entityTerritories.AddRange(employeeTerritories);
                return entityTerritories;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
        }
    }
}
