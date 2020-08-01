using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIHealthMonitorApplication.EntityScenario.DataAccess.Contexts;
using APIHealthMonitorApplication.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using APIHealthMonitorApplication.BussinesLogic;


namespace APIHealthMonitorApplication
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
            services.AddControllers();
            services.AddMemoryCache();

            services.AddDbContext<EntityScenarioDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EntityScenarioDatabase"));
                options.EnableSensitiveDataLogging(true);
                options.EnableServiceProviderCaching(true);
            });

            services.AddScoped<BussinesLogicService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<CustomExceptionMiddleware>();//This middleware was added for Custom global exception handling. Technically, we can add here many custom handlers.

            //app.UseHttpsRedirection(); //Uncomment this for https requests enabling

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
