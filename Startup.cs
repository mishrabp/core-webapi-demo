using corewebapidemo.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapidemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
          
            //add this, if this is a WebAPI Application
            services.AddControllers();

            //add this, if this is a MVC application
            //services.AddMvc();

            //add this, if this is a Razor application
            //services.AddRazorPages();

            services.AddTransient<CustomMiddleware1>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "test", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "test v1"));
            }

            //app.UseMiddleware<CustomMiddleware1>();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from customer middleware - 2 1 </br>");

            //    //await next();

            //    await context.Response.WriteAsync("Hello from customer middleware - 2 2 </br>");
            //});

            //Enables routing
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from WebAPI Project");
                });

                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello from new WebAPI app test. testing...."); 
                });

            });*/
        }
    }
}
