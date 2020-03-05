using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousesPeru.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
//using System.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using HousesPeru.Servicios;
using Microsoft.AspNetCore.Mvc;


namespace HousesPeru
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
         

            var SqlConnection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<HousesInPeruContext>(options => options.UseSqlServer(SqlConnection));


            services.AddTransient<IInmuebleService, InmuebleService>();


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            //services.AddMvc(options => options.EnableEndpointRouting = false);
            //services.AddControllers(options => options.EnableEndpointRouting = false);
            //services.AddControllersWithViews(options => options.EnableEndpointRouting = false);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseStaticFiles();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("areaRoute", "{area:exists}/{controller}/{action}");

            //    routes.MapRoute(
            //        name: "default",
            //        template: "/{controller=Home}/{action=Index}/{id?}");
            //});


        }
    }
}
