namespace ATM.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ATM.Model;

    public sealed class Configuration : DbMigrationsConfiguration<ATM.Data.ATMContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ATM.Data.ATMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.DepositAccounts.AddOrUpdate(x => x.CardNumber,
            // new DepositAccount() { Balance = 1000, CardNumber = 1111111111, CardPIN = 1111 },
            // new DepositAccount() { Balance = 2000, CardNumber = 2222222222, CardPIN = 1111 },
            // new DepositAccount() { Balance = 3000, CardNumber = 4444444444, CardPIN = 1111 },
            // new DepositAccount() { Balance = 4000, CardNumber = 5555555555, CardPIN = 1111 }
            // );
        }
    }
}
