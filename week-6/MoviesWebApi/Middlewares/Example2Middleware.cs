using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MoviesWebApi.Middlewares
{
    public class Example2Middleware
    {
        private readonly RequestDelegate _next;

        public Example2Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Example 2 Middleware'a girdi");

            // Call the next delegate/middleware in the pipeline
            await _next(context);

            Console.WriteLine("Example 2 Middleware'dan çıktı");

        }
    }
}
