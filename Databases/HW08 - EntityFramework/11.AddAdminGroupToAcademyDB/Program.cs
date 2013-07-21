using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using TelerikAcademyDB.Data;


namespace _11.AddAdminGroupToAcademyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User adminUser = new User() {UserName = "admin4o", FullName = "Bai Jeko", Password = "qwert1" };
            bool result = AddUserToGroup(adminUser, "Admins");
            Console.WriteLine(result == true? "One user added successfully" : "Error");
        }

        public static bool AddUserToGroup(User userToAdd, string groupName)
        {
            TelerikAcademyEntities dbContext = new TelerikAcademyEntities();
            bool success = false;
            using (dbContext)
            {
                try
                {
                    var userGroup = dbContext.Groups.Where(g => g.Name == groupName).FirstOrDefault();
                    if (userGroup == null)
                    {
                        Group created = new Group() { Name = groupName };
                        dbContext.Groups.Add(created);
                        userGroup = created;
                    }

                    userToAdd.GroupId = userGroup.GroupId;

                    dbContext.Users.Add(userToAdd);
                    dbContext.SaveChanges();
                    success = true;
                }
                catch (DbEntityValidationException ve)
                {
                    Console.WriteLine(ve.InnerException.Message);
                }
                catch (DbUpdateException ue)
                {
                    Console.WriteLine(ue.InnerException.Message);
                }
            }

            return success;
        }
    }
}
