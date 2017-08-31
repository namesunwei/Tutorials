using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe3.Middleware.Map.Sample2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region app.Map()支持复合（multiple）的方式匹配
            app.Map("/level1/level2", HandleMapTest3);
            #endregion

            #region app.Map() 支持多层嵌套的方式（nesting）匹配

            app.Map("/level1", level1App =>
             {
                 level1App.Map("/level2a", level2AApp =>
                 {
                    //"level1/level2a"
                    //...
                    level2AApp.Run(async context =>
                     {
                         await context.Response.WriteAsync("Hello from 'level1/level2a' delegate . <p>");
                     });
                 });
                 level1App.Map("/level2b", level2BApp =>
                 {
                    //"level1/level2b"
                    //...
                    level2BApp.Run(async context =>
                     {
                         await context.Response.WriteAsync("Hello from 'level1/level2b' delegate . <p>");
                     });
                 });
             });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate . <p>");
            }); 

            #endregion
        }
        private static void HandleMapTest3(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Multiple delegate <p>");
            });
        }
    }
}
