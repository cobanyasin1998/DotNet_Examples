using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Middlewares
{


    public class RequestResponseMiddlewares
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseMiddlewares> _logger;
        public RequestResponseMiddlewares(RequestDelegate next, ILogger<RequestResponseMiddlewares> logger)
        {
            _logger = logger;
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            //REQUEST

            var originalBodyStream = httpContext.Response.Body;

            _logger.LogInformation($"Query String: {httpContext.Request.QueryString}");

            MemoryStream requestBody = new MemoryStream();
            await httpContext.Response.Body.CopyToAsync(requestBody);
            requestBody.Seek(0,SeekOrigin.Begin);
            String requestText = await new StreamReader(requestBody).ReadToEndAsync();
            requestBody.Seek(0, SeekOrigin.Begin);


            var tempStream = new MemoryStream();
            httpContext.Response.Body = tempStream;
            await _next.Invoke(httpContext);
            httpContext.Response.Body.Seek(0, SeekOrigin.Begin);
            String responseText = await new StreamReader(httpContext.Response.Body, System.Text.Encoding.UTF8).ReadToEndAsync();
            httpContext.Response.Body.Seek(0, SeekOrigin.Begin);

            await httpContext.Response.Body.CopyToAsync(originalBodyStream);


            _logger.LogInformation($"Request: {requestText}");
            _logger.LogInformation($"Response: {responseText}");



            //RESPONSE
        }
    }
}
