using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schools.Data;
using Schools.Repositories;
using Schools.WebApi.Controllers;

namespace SchoolsWebApi.Tests
{
    [TestClass]
    public class StudentsControllerTest
    {
        private void SetupController(ApiController controller)
        {
            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost/api/students");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            var routeData = new HttpRouteData(route);
            routeData.Values.Add("id", RouteParameter.Optional);
            routeData.Values.Add("controller", "students");
            controller.ControllerContext = new HttpControllerContext(config, routeData, request);
            controller.Request = request;
            controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
            controller.Request.Properties[HttpPropertyKeys.HttpRouteDataKey] = routeData;
        }

        [TestMethod]
        public void Add_ValidStudent_ShouldBeAddedToDb()
        {
            var repository = new FakeRepository();

            var student = new Student()
            {
                StudentId = 1,
                FirstName = "Gosho",
                LastName = "Peshev",
                Age = 12,
                Grade = 5              
            };
            student.School = new School() { SchoolId = 1, Name = "test school", Location = "Burgas" };
            student.Marks.Add(new Mark() { MarkId = 1, Subject = "physics", Value = "4" });            

            repository.Add(student);
            var controller = new StudentsController(repository);
            SetupController(controller);

            var allStudents = controller.GetAll();

            Assert.IsTrue(allStudents.Count() == 1);
            Assert.AreEqual(student.LastName, allStudents.First().LastName);
        }
    }
}
