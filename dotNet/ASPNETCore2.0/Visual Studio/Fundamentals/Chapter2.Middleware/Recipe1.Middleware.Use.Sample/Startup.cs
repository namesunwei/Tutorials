using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe1.Middleware.Use.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region app.Use()方式的中间件
            /*
             * 1.app.Use()方式的中间件可以承接上一个中间件，处理请求，并传递给下一个中间件。
             */
            app.Use(async (context, next) =>
              {
                  await next.Invoke();
              });
            #endregion
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
