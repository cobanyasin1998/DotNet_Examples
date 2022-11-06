using Microsoft.AspNetCore.Mvc;
using System;

namespace Middlewares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public String Get()
        {

            throw new Exception("TEST HATASI");


            return "OK";
        }

        [HttpGet("Student")]
        public Student GetStudent()
        {

            return new Student()
            {
                Id = 1,
                FullName = "Yasin Çoban"
            };
        }
        [HttpPost("Student")]
        public String PostStudent([FromBody] Student student)
        {

            return "Öğrenci Oluşturuldu";
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public String FullName { get; set; }

    }
}
