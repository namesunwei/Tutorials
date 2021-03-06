﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Recipe2.Middleware.Use.Sample
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
             * 1.app.Use()方式的中间件可以承接上一个中间件，并传递给下一个中间件。
             */
            app.Use(async (context, next) =>
            {
                //Do work that doesn't write to the response.
                await next.Invoke();
                //Do logging or other work that doesn't write to the response.
            });
            #endregion

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
