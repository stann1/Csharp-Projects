namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.Models;

    public sealed class Configuration : DbMigrationsConfiguration<UniversityContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(UniversityContext context)
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

            context.Students.AddOrUpdate(new Student() { Name = "Peho kukata", StudentNumber = 100122 }, 
                                         new Student() { Name = "Stavri", StudentNumber = 100303 });

            context.Students
                .Where(s => s.Name == "Gosho Petrov").First()
                .Courses.Add(context.Courses.Where(c => c.Name == "Math101").First());

            context.SaveChanges();
        }
    }
}
