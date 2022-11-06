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
    }
}
