using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Recipe1.StartupSample.Data;

namespace Recipe1.StartupSample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            //初始化配置文件中的配置信息
            Configuration = configuration;
        }

        /// <summary>
        /// 1.该方法主要作用是对项目设置一些配置选项。
        /// 2.该方法时可选的，并且会在Configure()之前被调用。
        /// </summary>
        /// <remarks>IServiceCollection:当前容器中各种服务的配置集合</remarks>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //设置 使用 EntityFramework+SqlServer 作为数据访问技术
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //启用MVC功能
            services.AddMvc();
        }

        /// <summary>
        /// 设置当前程序如何响应HTTP请求，可以通过中间件（Middleware)来定制请求管道
        /// </summary>
        /// <remarks>IApplicationBuilder:被用来构建应用程序的请求管道.</remarks>
        /// <param name="app"></param>
        /// <remarks>IHostingEnvironment:提供了访问应用程序属性,类似于ApplicationName、ApplicationVersion 以及 ApplicationBasePath . </remarks>
        /// <param name="env"></param>
        /// <remarks>ILoggerFactory:提供了创建日志的机制</remarks>
        /// <param name="loggerFactory"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {   
                //添加测试环境使用的异常处理中间件
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                //添加其他环境下异常处理中间件
                app.UseExceptionHandler("/Home/Error");
            }

            // 添加静态文件的中间件
            app.UseStaticFiles();
            app.UseStaticFiles();

            //添加使用Mvc功能的中间件
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
