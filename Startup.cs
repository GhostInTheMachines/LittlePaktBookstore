using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittlePaktBookstore.Data;
using LittlePaktBookstore.Models;
using LittlePaktBookstore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LittlePaktBookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<LittlePacktBookStoreDbContex>(DbContextOptionBuilder =>
            DbContextOptionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LittlePackt;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddScoped<IRepository<Book>, SqlBooksRepository>();
            services.AddScoped<IRepository<Carousel>, CarouselRepository>();
            services.AddScoped<IRepository<Order>, SqlOrdersRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(ConfigureRoutes);
            app.UseStaticFiles();
        }

        private static void ConfigureRoutes(IRouteBuilder routes)
        {
            routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
