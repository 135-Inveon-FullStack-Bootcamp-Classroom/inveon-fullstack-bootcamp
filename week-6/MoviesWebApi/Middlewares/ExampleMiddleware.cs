using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MoviesWebApi.Middlewares
{
    public class ExampleMiddleware
    {
        private readonly RequestDelegate _next;

        public ExampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Example Middleware'a girdi");

            // Call the next delegate/middleware in the pipeline
            await _next(context);

            Console.WriteLine("Example Middleware'dan çıktı");

        }
    }
}
