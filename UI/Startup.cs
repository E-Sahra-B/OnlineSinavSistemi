using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;

namespace OnlineSinavSistemi.UI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<OnlineSinavSistemiContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".OSS.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.IsEssential = true;

            });
            services.AddMemoryCache();
            services.AddDistributedMemoryCache();
            //services.AddDistributedRedisCache(opytion => { opytion.Configuration = "localhost:42142"; });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);//Version_2_2
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<OnlineSinavSistemiContext>();
                context.Database.Migrate();
            }
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "Template")),
                RequestPath = "/tmp"
            });
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
           Path.Combine(Directory.GetCurrentDirectory(), "Areas/Admin/Images/BransLogo")),

                RequestPath = "/branslogos"
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();
            //app.UseMvc(x =>
            //{
            //    x.MapRoute("areas", "{area:exists}/{controller}/{action}/{id?}", new { controller = "Brans", Action = "Ekle" });
            //    x.MapRoute("default", "{controller}/{action}/{id?}", new { controller = "Home", Action = "Index" });
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                 name: "areas",
                 areaName: "areas",
                 pattern: "{area:exists}/{controller=Brans}/{action=Ekle}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
