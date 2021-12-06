using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace corewebapidemo.Middlewares
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from customer middleware - 1 1</br>");

            await next(context);

            await context.Response.WriteAsync("Hello from customer middleware - 1 2</br>");
        }
    }
}
