using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]

        public string Get()
        {
            NumGenerator n = new NumGenerator();

            int number = n.GetRandomNumber();

            return number.ToString();
        }
    }
}
