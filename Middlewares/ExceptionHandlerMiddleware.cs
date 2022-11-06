using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        public ExceptionHandlerMiddleware(RequestDelegate next,ILogger<ExceptionHandlerMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (System.Exception e)
            {
                //Hata Yönetimi
                _logger.LogError(e.Message);
             
            }

            
        }
    }
}
