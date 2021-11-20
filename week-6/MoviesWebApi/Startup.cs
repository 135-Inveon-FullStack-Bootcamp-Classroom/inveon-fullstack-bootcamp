using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MoviesWebApi.Middlewares;
using System;

namespace MoviesWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("ConfigureServices 1");
            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddControllers();

            Console.WriteLine("ConfigureServices 2");

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MoviesWebApi", Version = "v1" });
            });

            Console.WriteLine("ConfigureServices 3");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Console.WriteLine("Configure 1");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MoviesWebApi v1"));
            }

            Console.WriteLine("Configure 2");

            app.UseHttpsRedirection();
            Console.WriteLine("Configure 3");


            app.UseMiddleware<ExampleMiddleware>();
            Console.WriteLine("Configure 4");

            app.UseMiddleware<Example2Middleware>();
            Console.WriteLine("Configure 5");


            app.UseRouting();
            Console.WriteLine("Configure 6");

            app.UseAuthorization();
            Console.WriteLine("Configure 7");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            Console.WriteLine("Configure 8");

        }
    }
}
