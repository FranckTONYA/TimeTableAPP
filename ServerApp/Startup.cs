using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;
using ServerApp.Repositories.Implementations;

namespace ServerApp
{
    public class Startup
    {
        public IConfiguration Configuration;

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<bd_timetableContext>(options => {
                string configuration = Configuration["ConnectionStrings:MysqlConnection"];
                options.UseMySql(configuration);
            });

            services.AddMvc();
            services.AddSession();
            services.AddTransient<ITimeRepository,TimeRepository>();
            services.AddTransient<IClasseRepository, ClasseRepository>();
            services.AddTransient<IPeriodeRepository, PeriodeRepository>();
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy", builder => builder

                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowCredentials()
                );

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Classe}/{action=Index}/{id?}");
            });
        }
    }
}
