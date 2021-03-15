using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranQuangTruong_5951071114.Models;

namespace TranQuangTruong_5951071114.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            yield return new StudentInfo
            {
                Name = "Tran Quang Truong",
                Age = 21
            };
            ;
        }
    }
}
