using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _01_web_api.Controllers
{
    public class MonthController : ApiController
    {
        public IHttpActionResult GetMonth(int month)
        {

            if (month < 1 || month > 12)

                //returns a response with status code 400 (Bad Request)
                return BadRequest("please enter a valid month");

            DateTime date = new DateTime();  //response content
            return Ok(date);  //return a response with status code 200 + date as content
        }


        public IHttpActionResult GetDay(int day)
        {

            if (day < 1 || day > 7)

                //returns a response with status code 400 (Bad Request)
                return BadRequest("please enter a valid day");

            DateTime date = new DateTime();  //response content
            return Ok(date);  //return a response with status code 200 + date as content
        }
    }
}
