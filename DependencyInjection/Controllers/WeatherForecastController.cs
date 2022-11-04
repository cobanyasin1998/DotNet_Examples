using Microsoft.AspNetCore.Mvc;
using System;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet]
        public String Get()
        {
            NumGenerator n = new NumGenerator();

            int number = n.GetRandomNumber();

            return number.ToString();
        }
    }
}
