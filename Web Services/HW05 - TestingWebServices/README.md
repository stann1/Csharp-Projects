1. Create a database for the students database
Using MS SQL server 
2. Create a data layer that uses the above database
Use either database-first or code-first approach
3. Create a repositories layer that communicates with the data layer
4. Create a services layer using the repositories and:
- Use WebAPI
- Introduce a REST API that allows adding and getting of students to/from the Students database
The following endpoints should be present:
- GET api/students, GET api/students/{id},
- GET api/schools, GET api/schools/{id} 
- POST api/schools, POST api/students
- GET api/students?subject=math&value=5.00
Returns all students that have a mark for MATH and it is above 5.00
5. Write unit tests for:
- The StudentsRepository
- The StudentsController
