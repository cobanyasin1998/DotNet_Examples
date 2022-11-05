using Microsoft.AspNetCore.Mvc;
using System;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator2 _numGenerator2;
        private readonly INumGenerator _numGenerator;

        public WeatherForecastController(INumGenerator numGenerator,INumGenerator2 numGenerator2)
        {
            _numGenerator = numGenerator;
            _numGenerator2 = numGenerator2;
        }
        
        [HttpGet]
        public String Get()
        {
            int random1 = _numGenerator.RandomValue;

            int random2 =  _numGenerator2.GetNumGeneratorRandomNumber();


            return $"GetNumGeneratorRandomNumber: {random2}, RandomValue: {random1}";
        }
    }
}
