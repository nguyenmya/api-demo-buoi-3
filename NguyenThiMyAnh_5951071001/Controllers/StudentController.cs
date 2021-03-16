using NguyenThiMyAnh_5951071001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenThiMyAnh_5951071001.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public StudentInfo Get()
        {
            return new StudentInfo
            {
                MaSV = "5951071001",
                Ten = "Nguyễn Thị Mỹ Anh"
            };
        }
    }
}
