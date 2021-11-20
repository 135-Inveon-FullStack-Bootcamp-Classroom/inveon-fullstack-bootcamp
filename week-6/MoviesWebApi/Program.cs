using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace MoviesWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main 1");
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Main 2");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
