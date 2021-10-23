using FieldLevel.ActionFilter;
using FieldLevel.Data;
using FieldLevel.Interfaces;
using FieldLevel.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace FieldLevel
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<TimerFilter>();

            // Action filters registration
            services.Configure<ApiBehaviorOptions>(options =>
            {
                // override the default model validation 'error' messages behaviour (for fluent validation overriding)
                options.SuppressModelStateInvalidFilter = true;
            }).AddControllers(options =>
            {
                // apply filters from middleware to all controllers
                options.Filters.AddService(typeof(TimerFilter));
            });

            // add http client, for json fetching
            services.AddHttpClient("JsonClient")
                .ConfigureHttpClient(client =>
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts");
                });

            services.AddDbContext<FieldLevelDbContext>(context => { context.UseInMemoryDatabase("FieldLevelDb"); });
            services.AddScoped<FieldLevelDbContext>();
            services.AddScoped<IPostService, PostService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}