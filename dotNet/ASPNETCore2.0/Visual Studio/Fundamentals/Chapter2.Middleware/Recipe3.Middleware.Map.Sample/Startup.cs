using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe3.Middleware.Map.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            #region app.Map()方式的中间件
            /*
             * app.Map()用于分支管道的约定，根据给定的请求路径来匹配对应的请求管道，如果请求路径以给定路径开始，则执行对应的分支管道。
             */
            app.Map("/map1", HandleMapTest1);
            app.Map("/map2", HandleMapTest2);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate . <p>");
            });
            #endregion
        }
        private static void HandleMapTest1(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 1");
            });
        }
        private static void HandleMapTest2(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 2");
            });
        }
    }
}
