using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe1.Middleware.Run.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region App.Run()方式的中间件
            /*
             * 1.app.Run()方式的中间件可以承接上一个中间件 ，但不能传递给下一个中间件（终止中间件的传递），处理请求并直接响应请求。
             */
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            }); 
            #endregion
        }
    }
}
