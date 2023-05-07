using Microsoft.AspNetCore.HttpsPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Infrastructure.EF;
using Infrastructure.Generic;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo
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

            services.AddDbContext<EXDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EXDbContextConnection"), b => b.MigrationsAssembly("Demo")));

            services.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            }).CreateMapper());

            #region Services
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISinhVienRepository, SinhVienRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISinhVienService, SinhVienService>();


            #endregion
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                
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
        }
    }
}
