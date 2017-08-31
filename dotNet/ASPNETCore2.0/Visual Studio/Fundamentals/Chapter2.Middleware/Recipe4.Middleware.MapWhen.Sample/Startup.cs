using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe4.Middleware.MapWhen.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            #region app.MapWhen()方式的中间件

            app.MapWhen(context => context.Request.Query.ContainsKey("branch"), HandleBranch);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate . <p>");
            }); 
            
            #endregion
        }
        private static void HandleBranch(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var branchVer = context.Request.Query["branch"];
                await context.Response.WriteAsync($"Branch used = {branchVer}");
            });
        }
    }
}
