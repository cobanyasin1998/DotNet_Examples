using Microsoft.AspNetCore.Mvc;
using System;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator _numGenerator;
        public WeatherForecastController(INumGenerator numGenerator)
        {
            _numGenerator = numGenerator;
        }
        
        [HttpGet]
        public String Get()
        {
            //NumGenerator n = new NumGenerator();

            //int number = n.GetRandomNumber();

            return _numGenerator.GetRandomNumber().ToString();
        }
    }
}
