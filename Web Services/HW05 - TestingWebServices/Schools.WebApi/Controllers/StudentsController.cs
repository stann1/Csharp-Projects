using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Schools.Data;
using Schools.Repositories;
using System.Data.Entity;
using Schools.WebApi.Models;

namespace Schools.WebApi.Controllers
{
    public class StudentsController : ApiController
    {
        private IRepository<Student> studentsRepository;

        public StudentsController()
        {
            var dbContext = new SchoolsDBEntities();            
            this.studentsRepository = new DBStudentsRepository(dbContext);
        }

        public StudentsController(IRepository<Student> repository)
        {
            this.studentsRepository = repository;
        }

        // GET api/values
        public IEnumerable<StudentModel> GetAll()
        {
            var studentEntities = this.studentsRepository.All();
            var studentModels =
                from student in studentEntities
                select new StudentModel()
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Grade = (int)student.Grade,
                    School = student.School.Name,
                    Marks = (from mark in student.Marks
                             select new MarkModel()
                             {
                                 Subject = mark.Subject,
                                 Value = mark.Value
                             })
                };
            return studentModels.ToList();
        }

        // GET api/values/5
        public StudentModel Get(int id)
        {
            if (id <= 0)
            {
                var errResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The category id is not a valid number");
                throw new HttpResponseException(errResponse);
            }

            var student = this.studentsRepository.Get(id);

            var studentModel = new StudentModel()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Grade = (int)student.Grade,
                School = student.School.Name,
                Marks = (from mark in student.Marks
                         select new MarkModel()
                         {
                             Subject = mark.Subject,
                             Value = mark.Value
                         })
            };

            return studentModel;
        }

        public IEnumerable<StudentModel> GetStudentWithMarksInSubject(string subject, int value)
        {
            var selectedStudents = this.GetAll();
            var selected =
                from student in selectedStudents
                where student.Marks.Where(m => m.Subject.ToLower() == subject.ToLower() && m.Value == value.ToString()).Count() > 0
                select student;

            return selected.ToList();
        }

        // POST api/values
        public HttpResponseMessage Post(Student model)
        {
            if (model == null || model.FirstName == null || model.LastName == null)
            {
                var errResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The name of the student cannot be null or empty");
                return errResponse;
            }

            var entity = this.studentsRepository.Add(model);
            var response =
                Request.CreateResponse(HttpStatusCode.Created, entity);

            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.StudentId }));
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}