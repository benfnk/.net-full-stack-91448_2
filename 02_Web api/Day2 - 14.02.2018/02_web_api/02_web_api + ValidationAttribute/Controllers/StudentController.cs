using _02_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _02_web_api.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult GetAll()
        {
            //החזרת כל הסטודנטים
            return Ok(StudentStorage.StudentList);
        }

        // GET: api/Student/5
        public IHttpActionResult GetFullInfo(int grade)
        {
            if (grade > 100 || grade < 0)
                return BadRequest("Please enter a grade between 0-100");
            return Ok(StudentStorage.StudentList.Where(s => s.Grade == grade));
        }


        // GET: api/Student/5
        public IHttpActionResult GetSum(int grade)
        {
            if (grade > 100 || grade < 0)
                return BadRequest("Please enter a grade between 0-100");
            return Ok(StudentStorage.StudentList.Count(s => s.Grade == grade));
        }

        // POST: api/Student
        public IHttpActionResult Post([FromBody]Student value)
        {

            bool isValid = ModelState.IsValid;
            if (StudentStorage.AddStudentToList(value))
            {
                return Created("Added successfully", value);
            }
            return BadRequest("Please enter a student with a valid grade");
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody]Student value)
        {
            if (id >= 0 && id < StudentStorage.StudentList.Count())
            {
                if (value.Grade > 100 || value.Grade < 0)
                    return BadRequest("Please enter a student with a valid grade");

                StudentStorage.StudentList[id] = value;
                return Ok(value);



            }
            return NotFound();

        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            if (id >= 0 && id < StudentStorage.StudentList.Count())
            {
                StudentStorage.StudentList.RemoveAt(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
