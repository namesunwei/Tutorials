using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Recipe6.Middleware.ExtensionMethod.Middlewares;

namespace Recipe6.Middleware.ExtensionMethod
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            #region 添加自定义中间件到请求管道

            //通过扩展方法的形式添加到请求管道
            app.UseRequestIP();

            #endregion
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
