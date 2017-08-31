using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Recipe5.Middleware.Customer.Sample.Middlewares
{
    public class DisplayDateTimeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public DisplayDateTimeMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<DisplayDateTimeMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation($"Server datetime is {DateTime.Now} when user request.");
            await _next.Invoke(context);
        }
    }
}
