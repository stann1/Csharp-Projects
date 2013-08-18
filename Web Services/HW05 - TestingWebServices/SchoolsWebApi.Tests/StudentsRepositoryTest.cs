using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schools.Data;
using Schools.Repositories;
using System.Transactions;


namespace SchoolsWebApi.Tests
{
    [TestClass]
    public class StudentsRepositoryTest
    {
        public DbContext dbContext { get; set; }

        static Random rand = new Random();

        public IRepository<Student> categoriesRepository { get; set; }

        private static TransactionScope tranScope;

        public StudentsRepositoryTest()
        {
            this.dbContext = new SchoolsDBEntities();
            this.categoriesRepository = new DBStudentsRepository(this.dbContext);
        }

        [TestInitialize]
        public void TestInit()
        {
            tranScope = new TransactionScope();
        }

        [TestCleanup]
        public void TestTearDown()
        {
            tranScope.Dispose();
        }

        [TestMethod]
        public void Add_ValidStudent_ShouldBeAddedToDb()
        {
            var student = new Student()
            {
                FirstName = "Gosho",
                LastName = "Peshev",
                Age = 12,
                Grade = 5,
                SchoolId = 2
            };

            var addedStudent = this.categoriesRepository.Add(student);
            Assert.AreEqual(12, addedStudent.Age);
            Assert.AreEqual("Peshev", addedStudent.LastName);
        }

        [TestMethod]
        public void Add_ValidStudent_IdShouldNotBeNullInDB()
        {
            var student = new Student()
            {
                FirstName = "Gosho",
                LastName = "Peshev",
                Age = 12,
                Grade = 5,
                SchoolId = 2
            };

            var addedStudent = this.categoriesRepository.Add(student);
            var foundStudent = this.dbContext.Set<Student>().Find(addedStudent.StudentId);
            Assert.IsNotNull(foundStudent);
            Assert.AreEqual(foundStudent.StudentId, addedStudent.StudentId);
        }
    }
}
